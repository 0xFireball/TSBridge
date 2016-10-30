using System.Threading.Tasks;
using TSBridge;

namespace CompletionDemo
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
            const string mainFileName = "main.ts";
            //Load script
            string script = @"

class Program {
    static main() {
        console.log(""Hello, World!"");
    }
    static other() {
        console.log(""Hello, Other World!"");
    }
}

Program.main();
Progra
Program.
Program.ot
";
            tsCtx.OpenFile(mainFileName, script);
            var classNameCompletionInfo = tsCtx.GetCompletionsAtPosition(mainFileName, 192 /* The 'Progra' line*/);
            var methodCompletionInfo = tsCtx.GetCompletionsAtPosition(mainFileName, 202 /* The 'Program.' line*/);
            var noCompletionsInfo = tsCtx.GetCompletionsAtPosition(mainFileName, script.Length - 2);
        }
    }
}