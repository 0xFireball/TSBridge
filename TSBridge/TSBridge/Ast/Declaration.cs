using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public class Declaration : Node, IDeclaration
    {
        [JsonProperty("name")]
        public virtual IIdentifier Name { get; set; }
    }
}