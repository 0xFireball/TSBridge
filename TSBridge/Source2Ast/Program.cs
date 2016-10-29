using System.Threading.Tasks;
using TSBridge;

namespace Source2Ast
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Take some source code and output the AST
            RunMain().GetAwaiter().GetResult();
        }

        private static async Task RunMain()
        {
            var tsCtx = new TypeScriptContext();
            await tsCtx.LoadComponentsAsync();
            tsCtx.OpenFile("main.ts", @"

class Program {
    static main() {
        console.log(""Hello, World!"");
    }
}

Program.main();
");
            
        }
    }
}