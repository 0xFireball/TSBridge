using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public class Statement
    {
        [JsonProperty("pos")]
        public int Position { get; set; }
    }
}