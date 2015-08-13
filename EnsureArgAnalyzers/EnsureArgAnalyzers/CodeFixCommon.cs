using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EnsureArgAnalyzers
{
    public static class CodeFixCommon
    {
        public static async Task<Document> ChangeArgumentAsync(
            Document document,
            ArgumentListSyntax argumentListNode,
            string newParameterName,
            CancellationToken cancellationToken)
        {
            // Find the Identifier Name for the first argument to Ensure.Arg.
            var argumentNodes = argumentListNode.DescendantNodes()
                                                .OfType<ArgumentSyntax>();

            if (argumentNodes.Count() == 0)
            {
                return document;
            }

            ArgumentSyntax newIdentifierArg = SyntaxFactory.Argument(SyntaxFactory.IdentifierName(newParameterName));
            ArgumentSyntax newNameOfArg = SyntaxFactory.Argument(CreateLiteralForIdentifier(document, newParameterName));

            SyntaxNode root = await document.GetSyntaxRootAsync(cancellationToken);

            var newRoot = root.ReplaceNode(argumentListNode,
                SyntaxFactory.ArgumentList(
                    SyntaxFactory.SingletonSeparatedList(newIdentifierArg)
                       .Add(newNameOfArg))
                    .AddArguments(argumentListNode.Arguments
                                                  .Skip(2)
                                                  .ToArray()));

            return document.WithSyntaxRoot(newRoot);
        }

        private static ExpressionSyntax CreateLiteralForIdentifier(Document document, string identifierName)
        {
            if ((document.Project.ParseOptions as CSharpParseOptions)?.LanguageVersion >= LanguageVersion.CSharp6)
            {
                return CreateNameOfStatement(identifierName);
            }

            return SyntaxFactory.LiteralExpression(
                SyntaxKind.StringLiteralExpression,
                SyntaxFactory.Literal(identifierName));
        }

        private static InvocationExpressionSyntax CreateNameOfStatement(string nameOfValueText)
        {
            return SyntaxFactory.InvocationExpression(
                        SyntaxFactory.IdentifierName(
                            @"nameof"))
                        .WithArgumentList(
                            SyntaxFactory.ArgumentList(
                                SyntaxFactory.SingletonSeparatedList(
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.IdentifierName(
                                            nameOfValueText)))));
        }
    }
}
