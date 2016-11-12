namespace TSBridge.Ast.Statements
{
    public abstract class ClassDeclaration : Declaration, IDeclarationStatement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.ClassDeclaration;
    }
}