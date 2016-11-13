namespace TSBridge.Ast.Statements
{
    public class ClassDeclaration : ClassLikeDeclaration, IDeclarationStatement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.ClassDeclaration;
    }
}