using Newtonsoft.Json;
using TSBridge.Ast.SubNodes.Organization;

namespace TSBridge.Ast.SubNodes.Declarations
{
    public class FunctionLikeDeclaration : Declaration, IFunctionLikeDeclaration
    {
        [JsonProperty("body")]
        public IBlockOrExpression Body { get; set; }
    }
}