﻿using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public interface INode : ITextRange
    {
        [JsonProperty("kind")]
        SyntaxKind Kind { get; set; }

        [JsonProperty("flags")]
        NodeFlags Flags { get; set; }

        [JsonProperty("parent")]
        INode Parent { get; set; }
    }
}