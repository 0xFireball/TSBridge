using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public abstract class Node : INode
    {
        [JsonProperty("kind")]
        public virtual SyntaxKind Kind { get; set; }

        [JsonProperty("flags")]
        public virtual NodeFlags Flags { get; set; }

        [JsonProperty("parent")]
        public virtual INode Parent { get; set; }

        [JsonProperty("pos")]
        public virtual int Position { get; set; }

        [JsonProperty("end")]
        public virtual int End { get; set; }
    }
}