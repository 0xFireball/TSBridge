using Newtonsoft.Json;

namespace TSBridge.Ast.SubNodes.Organization
{
    public class BlockOrExpression : Statement, IBlockOrExpression
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.Block;

        [JsonProperty("statements")]
        public NodeArray<IStatement> Statements { get; set; }
    }
}