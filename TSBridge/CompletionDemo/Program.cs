using System;
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
            tsCtx.OpenFile(mainFileName, @"

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
");
            var completionInfo = tsCtx.GetCompletionsAtPosition(mainFileName, mainFileName.Length);
            Console.WriteLine(completionInfo);
        }
    }
}