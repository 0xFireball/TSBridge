using Newtonsoft.Json;

namespace TSBridge.Ast.SubNodes.Organization
{
    public class Block : Statement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.Block;

        [JsonProperty("statements")]
        public NodeArray<IStatement> Statements { get; set; }
    }
}