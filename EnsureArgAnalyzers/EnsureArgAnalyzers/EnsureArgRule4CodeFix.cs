using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EnsureArgAnalyzers
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(EnsureArgRule4CodeFix)), Shared]
    public class EnsureArgRule4CodeFix : CodeFixProvider
    {        
        public const string DiagnosticId = EnsureArgAnalyzersAnalyzer.EnsureArgDiagnosticId4;

        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(DiagnosticId); }
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

            var ensureArgNode = root.FindNode(diagnosticSpan) as InvocationExpressionSyntax;

            string fixTitle = "Add IsNotNull guard clause";

            context.RegisterCodeFix(
                diagnostic: diagnostic,
                action: CodeAction.Create(
                    title: fixTitle,
                    equivalenceKey: fixTitle,
                    createChangedDocument: cancellationToken =>
                       AddIsNotNullAsync(
                           context.Document,
                           ensureArgNode,
                           cancellationToken)));
        }

        private static async Task<Document> AddIsNotNullAsync(
            Document document,
            InvocationExpressionSyntax ensureArgNode,
            CancellationToken cancellationToken)
        {
            DocumentEditor editor = await DocumentEditor.CreateAsync(document);

            var isNotNullExpression =
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        ensureArgNode,
                        SyntaxFactory.IdentifierName("IsNotNull")),
                    SyntaxFactory.ArgumentList());
            
            editor.ReplaceNode(ensureArgNode, isNotNullExpression);

            return editor.GetChangedDocument();
        }
    }
}