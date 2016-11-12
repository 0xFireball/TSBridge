using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public abstract class Node : ITextRange
    {
        [JsonProperty("kind")]
        public SyntaxKind Kind { get; set; }

        [JsonProperty("flags")]
        public NodeFlags Flags { get; set; }

        [JsonProperty("parent")]
        public Node Parent { get; set; }

        [JsonProperty("pos")]
        public int Position { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }
}