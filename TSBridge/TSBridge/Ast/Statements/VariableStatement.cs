using Newtonsoft.Json;

namespace TSBridge.Ast.Statements
{
    public class VariableStatement : Statement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.VariableStatement;

        [JsonProperty("declarationList")]
        public VariableDeclarationList DeclarationList { get; set; }
    }
}