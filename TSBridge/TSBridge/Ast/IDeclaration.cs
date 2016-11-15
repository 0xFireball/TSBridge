using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public interface IDeclaration : INode
    {
        [JsonProperty("name")]
        IIdentifier Name { get; set; }
    }
}