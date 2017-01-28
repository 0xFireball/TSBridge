namespace TSBridge.Ast
{
    public interface IClassLikeDeclaration : IDeclaration
    {
        NodeArray<IClassElement> Members { get; set; }
    }
}