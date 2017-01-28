namespace TSBridge.Ast.SubNodes.Declarations
{
    public class VariableDeclaration : Declaration
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.VariableDeclaration;
    }
}