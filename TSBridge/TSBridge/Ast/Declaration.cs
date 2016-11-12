using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public class Declaration : Statement, IDeclaration
    {
        [JsonProperty("name")]
        public virtual IIdentifier Name { get; set; }
    }
}