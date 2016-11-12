using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public interface ITextRange
    {
        [JsonProperty("pos")]
        int Position { get; set; }

        [JsonProperty("end")]
        int End { get; set; }
    }
}