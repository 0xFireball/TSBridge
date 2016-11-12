namespace TSBridge.Ast.Statements
{
    public abstract class ClassDeclaration : DeclarationStatement, IDeclaration
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.ClassDeclaration;
    }
}