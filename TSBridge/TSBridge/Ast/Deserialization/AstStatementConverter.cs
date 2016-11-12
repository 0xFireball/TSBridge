using Newtonsoft.Json.Linq;
using System;
using TSBridge.Ast.Statements;

namespace TSBridge.Ast.Deserialization
{
    public class AstStatementConverter : JsonCreationConverter<Statement>
    {
        protected override Statement Create(Type objectType, JObject jsonObject)
        {
            var statementKind = jsonObject["kind"].Value<SyntaxKind>();
            switch (statementKind)
            {
                case SyntaxKind.ClassDeclaration:
                    return new ClassDeclaration();
                default:
                    return new Statement();
            }
        }
    }
}