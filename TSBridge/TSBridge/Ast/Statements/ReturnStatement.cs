namespace TSBridge.Ast.Statements
{
    public class ReturnStatement : Statement
    {
        public override SyntaxKind Kind { get; set; } = SyntaxKind.ReturnStatement;
    }
}