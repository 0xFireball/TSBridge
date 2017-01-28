namespace TSBridge.Ast.SubNodes.ClassElements
{
    public class ConstructorDeclaration : ClassElement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.Constructor;
    }
}