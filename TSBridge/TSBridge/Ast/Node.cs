using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public class Node
    {
        [JsonProperty("kind")]
        public SyntaxKind Kind { get; set; }

        [JsonProperty("flags")]
        public NodeFlags Flags { get; set; }

        [JsonProperty("parent")]
        public Node Parent { get; set; }
    }
}