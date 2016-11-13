using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSBridge.Ast
{
    public class NodeArray<T> : List<T>, ITextRange where T : INode
    {
        [JsonProperty("hasTrailingComma")]
        public bool HasTrailingComma { get; set; }

        [JsonProperty("pos")]
        public int Position { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }
}