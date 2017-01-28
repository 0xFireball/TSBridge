namespace TSBridge.Ast.Statements
{
    public class FunctionDeclaration : FunctionLikeDeclaration, IDeclarationStatement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.ClassDeclaration;
    }
}