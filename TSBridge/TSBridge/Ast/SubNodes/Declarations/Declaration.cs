using Newtonsoft.Json;

namespace TSBridge.Ast.SubNodes.Declarations
{
    public class Declaration : Node, IDeclaration
    {
        [JsonProperty("name")]
        public virtual IIdentifier Name { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}