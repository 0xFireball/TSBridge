namespace TSBridge.Ast.Statements
{
    public class ClassDeclaration : DeclarationStatement, IDeclaration
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.ClassDeclaration;
    }
}