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
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(EnsureArgRule3CodeFix)), Shared]
    public class EnsureArgRule3CodeFix : CodeFixProvider
    {
        public const string DiagnosticId = "EnsureArgRule3CodeFix";

        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(EnsureArgAnalyzersAnalyzer.EnsureArgDiagnosticId3); }
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

            var argumentListNode = root.FindNode(diagnosticSpan)
                           .Ancestors()
                           .OfType<ArgumentListSyntax>()
                           .FirstOrDefault();

            var firstParameterIdentifier = argumentListNode.Arguments
                                                           .First()
                                                           .Expression as IdentifierNameSyntax;

            string firstParameterName = firstParameterIdentifier.Identifier.ValueText;
            string fixTitle = $"Change second argument to nameof({firstParameterName})";

            context.RegisterCodeFix(
                diagnostic: diagnostic,
                action: CodeAction.Create(
                    title: fixTitle,
                    equivalenceKey: fixTitle,
                    createChangedDocument: cancellationToken =>
                       CodeFixCommon.ChangeArgumentAsync(
                           context.Document,
                           argumentListNode,
                           firstParameterName,
                           cancellationToken)));
        }
    }
}