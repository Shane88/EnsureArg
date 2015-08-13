namespace EnsureArgAnalyzers
{
    using System.Collections.Immutable;
    using System.Linq;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.CodeAnalysis.Diagnostics;

    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class EnsureArgAnalyzersAnalyzer : DiagnosticAnalyzer
    {
        // TODO: Analyzer #5 - Detect parameters to public methods which do not have a null guard and offer Ensure.Arg.
        // TODO: Analyzer #6 - Detect traditional null guard and offer conversion to Ensure.Arg.

        /// <summary>
        /// Analyzer #1 - Detect arguments to the first parameter of Ensure.Arg() are not parameters of the containing method.
        /// </summary>
        public const string EnsureArgDiagnosticId1 = "EnsureArgAnalyzer1";

        /// <summary>
        /// Analyzer #2 - Detect incorrect argument names to second parameter or Ensure.Arg().
        /// </summary>
        public const string EnsureArgDiagnosticId2 = "EnsureArgAnalyzer2";

        /// <summary>
        /// Analyzer #3 - Detect valid use, but with second parameter as a string and update to nameof operator.
        /// </summary>
        public const string EnsureArgDiagnosticId3 = "EnsureArgAnalyzer3";

        /// <summary>
        /// Analyzer #4 - Detect when Ensure.Arg is called with no follow up method e.g. IsNotNull(). 
        /// // TODO: Create code fix for this.
        /// </summary>
        public const string EnsureArgDiagnosticId4 = "EnsureargAnalyzer4";

        // You can change these strings in the Resources.resx file. If you do not want your analyzer to be localize-able, you can use regular strings for Title and MessageFormat.
        private static readonly LocalizableString Title1 = new LocalizableResourceString(nameof(Resources.AnalyzerTitle1), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat1 = new LocalizableResourceString(nameof(Resources.AnalyzerMessageFormat1), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description1 = new LocalizableResourceString(nameof(Resources.AnalyzerDescription1), Resources.ResourceManager, typeof(Resources));

        private static readonly LocalizableString Title2 = new LocalizableResourceString(nameof(Resources.AnalyzerTitle2), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat2 = new LocalizableResourceString(nameof(Resources.AnalyzerMessageFormat2), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description2 = new LocalizableResourceString(nameof(Resources.AnalyzerDescription2), Resources.ResourceManager, typeof(Resources));

        private static readonly LocalizableString Title3 = new LocalizableResourceString(nameof(Resources.AnalyzerTitle3), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat3 = new LocalizableResourceString(nameof(Resources.AnalyzerMessageFormat3), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description3 = new LocalizableResourceString(nameof(Resources.AnalyzerDescription3), Resources.ResourceManager, typeof(Resources));

        private static readonly LocalizableString Title4 = new LocalizableResourceString(nameof(Resources.AnalyzerTitle4), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat4 = new LocalizableResourceString(nameof(Resources.AnalyzerMessageFormat4), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description4 = new LocalizableResourceString(nameof(Resources.AnalyzerDescription4), Resources.ResourceManager, typeof(Resources));

        private static DiagnosticDescriptor Rule1 = 
            new DiagnosticDescriptor(
                EnsureArgDiagnosticId1, 
                Title1, 
                MessageFormat1, 
                category: "Syntax",
                defaultSeverity: DiagnosticSeverity.Warning, 
                isEnabledByDefault: true, 
                description: Description1);

        private static DiagnosticDescriptor Rule2 =
            new DiagnosticDescriptor(
                EnsureArgDiagnosticId2,
                Title2,
                MessageFormat2,
                category: "Syntax",
                defaultSeverity: DiagnosticSeverity.Warning,
                isEnabledByDefault: true,
                description: Description2);

        private static DiagnosticDescriptor Rule3 =
            new DiagnosticDescriptor(
                EnsureArgDiagnosticId3,
                Title3,
                MessageFormat3,
                category: "Syntax",
                defaultSeverity: DiagnosticSeverity.Warning,
                isEnabledByDefault: true,
                description: Description3);

        private static DiagnosticDescriptor Rule4 =
            new DiagnosticDescriptor(
                EnsureArgDiagnosticId4,
                Title4,
                MessageFormat4,
                category: "Syntax",
                defaultSeverity: DiagnosticSeverity.Warning,
                isEnabledByDefault: true,
                description: Description4);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                return ImmutableArray.Create(Rule1, Rule2, Rule3, Rule4);
            }
        }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.InvocationExpression);
        }

        private static bool IsNodeEnsureArgCall(SyntaxNodeAnalysisContext context, InvocationExpressionSyntax invocationExpr)
        {
            if (invocationExpr == null)
            {
                return false;
            }

            var memberAccessExpr = invocationExpr.Expression as MemberAccessExpressionSyntax;

            // Do fastest check we can first so we can bail out fast.
            if (memberAccessExpr?.Name.ToString() != "Arg")
            {
                return false;
            }

            var memberSymbol =
                context.SemanticModel.GetSymbolInfo(memberAccessExpr).Symbol as IMethodSymbol;

            if (memberSymbol?.ToString().StartsWith("EnsureArg.Ensure.Arg") ?? true)
            {
                return true;
            }

            return false;
        }

        private void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            if (!context.Node.IsKind(SyntaxKind.InvocationExpression))
            {
                return;
            }

            var invocationExpr = context.Node as InvocationExpressionSyntax;

            if (!IsNodeEnsureArgCall(context, invocationExpr))
            {
                return;
            }

            var argumentList = invocationExpr.ArgumentList as ArgumentListSyntax;

            if ((argumentList?.Arguments.Count ?? 0) < 1)
            {
                return;
            }

            var firstArgumentNameSyntax = argumentList.Arguments[0].Expression as IdentifierNameSyntax;

            if (firstArgumentNameSyntax == null)
            {
                return;
            }

            var methodDeclaration = context.Node
                                           .Ancestors()
                                           .OfType<MethodDeclarationSyntax>()
                                           .FirstOrDefault();

            string firstArgumentName = firstArgumentNameSyntax.Identifier.ValueText;

            if (methodDeclaration != null)
            {
                var methodParameters = methodDeclaration.ParameterList.Parameters.Select(p => p.Identifier.ValueText);

                if (!methodParameters.Contains(firstArgumentName))
                {
                    var diagnostic =
                        Diagnostic.Create(
                            Rule1,
                            firstArgumentNameSyntax.GetLocation(),
                            firstArgumentName,
                            methodDeclaration.Identifier);

                    context.ReportDiagnostic(diagnostic);
                }
            }

            if (argumentList.Arguments.Count >= 2)
            {
                ExpressionSyntax secondArgument = argumentList.Arguments[1].Expression;
                string secondParameterText = null;
                Location diagnosticLocation = null;

                // String Literal e.g. Ensure.Arg(a, "b");
                if (secondArgument.IsKind(SyntaxKind.StringLiteralExpression))
                {
                    var stringLiteral = secondArgument as LiteralExpressionSyntax;

                    secondParameterText = stringLiteral.Token.ValueText;
                    diagnosticLocation = stringLiteral.GetLocation();

                    if (secondParameterText == firstArgumentName)
                    {
                        var diagnostic =
                            Diagnostic.Create(
                                Rule3,
                                diagnosticLocation,
                                secondParameterText);

                        context.ReportDiagnostic(diagnostic);
                    }
                }

                // Detect if using nameof operator e.g. Ensure.Arg(a, nameof(b));
                if (secondArgument.IsKind(SyntaxKind.InvocationExpression))
                {
                    var invocationExpression = secondArgument as InvocationExpressionSyntax;

                    var nameOfIdentifier = invocationExpression.ChildNodes().FirstOrDefault() as IdentifierNameSyntax;

                    if (nameOfIdentifier.Identifier.ValueText == "nameof")
                    {
                        // Definitely nameof operater, keep digging to get to the identifier argument.
                        var nameOfIdentifierArgument = invocationExpression.DescendantNodes()
                                                                           .OfType<ArgumentListSyntax>()
                                                                           .FirstOrDefault()
                                                                          ?.Arguments
                                                                           .FirstOrDefault()
                                                                          ?.Expression as IdentifierNameSyntax;

                        secondParameterText = nameOfIdentifierArgument?.Identifier.ValueText;
                        diagnosticLocation = invocationExpression.GetLocation();
                    }
                }

                if (secondParameterText != firstArgumentName)
                {
                    var diagnostic =
                        Diagnostic.Create(
                            Rule2,
                            diagnosticLocation,
                            secondParameterText,
                            firstArgumentName);

                    context.ReportDiagnostic(diagnostic);
                }

                var methodIdentifier = invocationExpr.Parent
                                                     .ChildNodes()
                                                     .OfType<IdentifierNameSyntax>()
                                                     .FirstOrDefault();

                if (methodIdentifier == null)
                {
                    var diagnostic = Diagnostic.Create(
                        Rule4,
                        invocationExpr.GetLocation());

                    context.ReportDiagnostic(diagnostic);
                }
            }
        }
    }
}
