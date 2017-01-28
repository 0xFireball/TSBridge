using TSBridge.Ast.SubNodes.Organization;

namespace TSBridge.Ast.SubNodes.Declarations
{
    public interface IFunctionLikeDeclaration : IDeclaration
    {
        BlockOrExpression Body { get; set; }
    }
}