using Newtonsoft.Json.Linq;
using System;
using TSBridge.Ast.SubNodes.ClassElements;

namespace TSBridge.Ast.Deserialization
{
    public class ClassElementConverter : JsonCreationConverter<IClassElement>
    {
        protected override IClassElement Create(Type objectType, JObject jsonObject)
        {
            var elementKindNumber = jsonObject["kind"].Value<int>();

            var elementKind = (SyntaxKind)elementKindNumber;

            switch (elementKind)
            {
                case SyntaxKind.Constructor:
                    return new ConstructorDeclaration();
                case SyntaxKind.MethodDeclaration:
                    return new MethodDeclaration();
                default:
                    return new ClassElement();
            }
        }
    }
}