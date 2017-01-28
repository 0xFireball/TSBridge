using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public class ClassLikeDeclaration : Declaration, IClassLikeDeclaration
    {
        [JsonProperty("members")]
        public NodeArray<IClassElement> Members { get; set; }
    }
}