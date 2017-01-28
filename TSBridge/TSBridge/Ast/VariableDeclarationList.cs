using Newtonsoft.Json;
using TSBridge.Ast.SubNodes.Declarations;

namespace TSBridge.Ast
{
    public class VariableDeclarationList : Node
    {
        [JsonProperty("declarations")]
        public NodeArray<VariableDeclaration> Declarations { get; set; }
    }
}