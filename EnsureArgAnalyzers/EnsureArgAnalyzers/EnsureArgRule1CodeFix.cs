using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;

namespace EnsureArgAnalyzers
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(EnsureArgRule1CodeFix)), Shared]
    public class EnsureArgRule1CodeFix : CodeFixProvider
    {
        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(EnsureArgAnalyzersAnalyzer.EnsureArgDiagnosticId1); }
        }

        public sealed override FixAllProvider GetFixAllProvider()
        {
            return WellKnownFixAllProviders.BatchFixer;
        }

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken)
                                             .ConfigureAwait(false);
            
            Diagnostic diagnostic = context.Diagnostics.First();
            TextSpan diagnosticSpan = diagnostic.Location.SourceSpan;

            // Find the method that contains the EnsureArg call.
            var containingMethod = root.FindNode(diagnosticSpan)
                                       .Ancestors()
                                       .OfType<MethodDeclarationSyntax>()
                                       .FirstOrDefault();

            if (containingMethod == null)
            {
                return;
            }

            var argumentListNode = root.FindNode(diagnosticSpan)
                                       .Ancestors()
                                       .OfType<ArgumentListSyntax>()
                                       .FirstOrDefault();

            var methodParameters = containingMethod.ParameterList.Parameters.Select(p => p.Identifier.ValueText);

            foreach (string parameterName in methodParameters)
            {
                string fixTitle = $"Change first argument to {parameterName}";

                context.RegisterCodeFix(
                    diagnostic: diagnostic,
                    action: CodeAction.Create(
                        title: fixTitle,
                        equivalenceKey: fixTitle,
                        createChangedDocument: cancellationToken => 
                           CodeFixCommon.ChangeArgumentAsync(
                               context.Document,
                               argumentListNode,
                               parameterName, 
                               cancellationToken)));
            }
        }
    }
}