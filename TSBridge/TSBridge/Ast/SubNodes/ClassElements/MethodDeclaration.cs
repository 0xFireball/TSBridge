using TSBridge.Ast.SubNodes.Declarations;

namespace TSBridge.Ast.SubNodes.ClassElements
{
    public class MethodDeclaration : FunctionLikeDeclaration, IClassElement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.MethodDeclaration;
    }
}