using TSBridge.Ast.SubNodes.Organization;

namespace TSBridge.Ast.SubNodes.Declarations
{
    public interface IFunctionLikeDeclaration : IDeclaration
    {
        IBlockOrExpression Body { get; set; }
    }
}