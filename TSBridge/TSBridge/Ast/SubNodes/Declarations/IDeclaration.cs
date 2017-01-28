using Newtonsoft.Json;

namespace TSBridge.Ast.SubNodes.Declarations
{
    public interface IDeclaration : INode
    {
        [JsonProperty("name")]
        IIdentifier Name { get; set; }
    }
}