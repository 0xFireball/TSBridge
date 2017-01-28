using Newtonsoft.Json.Linq;
using System;

namespace TSBridge.Ast.Deserialization
{
    public class ExpressionConverter : JsonCreationConverter<IExpression>
    {
        protected override IExpression Create(Type objectType, JObject jsonObject)
        {
            return new BaseExpression(); // Default implementation
        }
    }
}