using System;
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
            var astJson = tsCtx.BuildAstJson("main.ts", @"

class Program {
    static main() {
        console.log(""Hello, World!"");
    }
}

class Person {
    constructor(public name: string) {
    }

    public sayHello() {
        console.log(this.name + "" says hello!"");
    }
}

class IceCreamSandwich {
    constructor(public size: number) {
    }
    public add(a: number, b: number) {
        return a + b;
    }
}

let bob = new Person(""Bob"");
bob.sayHello();

Program.main();

let num = (new IceCreamSandwich(11)).add(1, 2);
// num = ""error"";
");
            Console.WriteLine(astJson);
        }
    }
}