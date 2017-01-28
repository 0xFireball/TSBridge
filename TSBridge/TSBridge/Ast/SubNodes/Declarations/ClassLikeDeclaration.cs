using Newtonsoft.Json;

namespace TSBridge.Ast.SubNodes.Declarations
{
    public class ClassLikeDeclaration : Declaration, IClassLikeDeclaration
    {
        [JsonProperty("members")]
        public NodeArray<IClassElement> Members { get; set; }
    }
}