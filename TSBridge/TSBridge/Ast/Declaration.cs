using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public class Declaration : Node
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}