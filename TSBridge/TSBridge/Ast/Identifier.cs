using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public class Identifier : Node, IIdentifier
    {
        [JsonProperty("kind")]
        public override SyntaxKind Kind { get; set; } = SyntaxKind.Identifier;

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("originalKeywordKind")]
        public SyntaxKind OriginalKeywordKind { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}