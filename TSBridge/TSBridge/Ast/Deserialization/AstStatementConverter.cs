using Newtonsoft.Json.Linq;
using System;
using TSBridge.Ast.Statements;

namespace TSBridge.Ast.Deserialization
{
    /// <summary>
    /// Helps deserialize statements in the AST
    /// </summary>
    public class AstStatementConverter : JsonCreationConverter<IStatement>
    {
        protected override IStatement Create(Type objectType, JObject jsonObject)
        {
            var statementKindNumber = jsonObject["kind"].Value<int>();

            var statementKind = (SyntaxKind)statementKindNumber;

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