using System;
using Newtonsoft.Json.Linq;

namespace TSBridge.Ast.Deserialization
{
    public class AstConverter : JsonCreationConverter<TypeScriptSyntaxTree>
    {
        protected override TypeScriptSyntaxTree Create(Type objectType, JObject jsonObject)
        {
            return new TypeScriptSyntaxTree();
        }
    }
}