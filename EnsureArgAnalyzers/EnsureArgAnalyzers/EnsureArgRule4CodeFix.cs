using System;
using System.Composition;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Rename;
using Microsoft.CodeAnalysis.Text;

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

            var ensureArgWithIsNotNull = 
                ensureArgNode.InsertTokensBefore(
                    SyntaxFactory.Token(SyntaxKind.SemicolonToken),
                    new[] { SyntaxFactory.Token(SyntaxKind.DotToken) })
                .WithExpression(SyntaxFactory.IdentifierName("IsNotNull"));

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
                           ensureArgWithIsNotNull,
                           cancellationToken)));
        }

        private static async Task<Document> AddIsNotNullAsync(
            Document document, 
            InvocationExpressionSyntax ensureArgNode,
            InvocationExpressionSyntax updatedNode,
            CancellationToken cancellationToken)
        {
            SyntaxNode root = await document.GetSyntaxRootAsync(cancellationToken);

            var newRoot = root.ReplaceNode(ensureArgNode, updatedNode);

            return document.WithSyntaxRoot(newRoot);
        }
    }
}