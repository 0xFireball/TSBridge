using System;
using Newtonsoft.Json.Linq;

namespace TSBridge.Ast.Deserialization
{
    public class IdentifierConverter : JsonCreationConverter<IIdentifier>
    {
        protected override IIdentifier Create(Type objectType, JObject jsonObject)
        {
            return new Identifier();
        }
    }
}