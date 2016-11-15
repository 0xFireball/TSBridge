using Newtonsoft.Json;

namespace TSBridge.Ast
{
    public interface IDeclarationStatement : IDeclaration, IStatement
    {
        [JsonProperty("name")]
        IIdentifier Name { get; set; }
    }
}