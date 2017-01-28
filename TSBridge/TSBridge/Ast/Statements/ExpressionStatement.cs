using Newtonsoft.Json;

namespace TSBridge.Ast.Statements
{
    public class ExpressionStatement : Statement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.ExpressionStatement;

        [JsonProperty("expression")]
        public IExpression Expression { get; set; }
    }
}