using Newtonsoft.Json.Linq;
using System;
using TSBridge.Ast.Statements;
using TSBridge.Ast.SubNodes.Organization;

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

                case SyntaxKind.Block:
                    return new BlockOrExpression();
                // Method body statements
                case SyntaxKind.ReturnStatement:
                    return new ReturnStatement();
                // Misc. statements
                case SyntaxKind.ExpressionStatement:
                    return new ExpressionStatement();
                case SyntaxKind.VariableStatement:
                    return new VariableStatement();
                default:
                    return new Statement();
            }
        }
    }
}