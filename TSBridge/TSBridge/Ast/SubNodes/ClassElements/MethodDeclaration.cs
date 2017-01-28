namespace TSBridge.Ast.SubNodes.ClassElements
{
    public class MethodDeclaration : ClassElement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.MethodDeclaration;
    }
}