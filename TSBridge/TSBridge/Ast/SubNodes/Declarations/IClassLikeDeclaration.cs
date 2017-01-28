namespace TSBridge.Ast.SubNodes.Declarations
{
    public interface IClassLikeDeclaration : IDeclaration
    {
        NodeArray<IClassElement> Members { get; set; }
    }
}