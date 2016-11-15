using Newtonsoft.Json;

namespace TSBridge.Ast.Statements
{
    public class DeclarationStatement : Statement, IDeclarationStatement
    {
        [JsonProperty("name")]
        public IIdentifier Name { get; set; }
    }
}