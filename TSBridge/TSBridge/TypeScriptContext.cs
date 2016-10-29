using Jint;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TSBridge.Services;

namespace TSBridge
{
    public class TypeScriptContext
    {
        private Engine _jsEngine;
        public LanguageServiceHost Host { get; set; }
        public CompilerOptions CompilerOptions { get; }

        public TypeScriptContext(CompilerOptions options)
        {
            _jsEngine = new Engine(x => { x.AllowClr(typeof(TypeScriptContext).Assembly); });
            Host = new LanguageServiceHost(options, new NullLogger());
        }

        public TypeScriptContext() : this(new CompilerOptions())
        {
        }

        public void LoadComponents()
        {
            // Load the compiler services
            var compilerSourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("TSBridge.JS.typescriptServices.js");
            var compilerSource = ReadStream(compilerSourceStream);
            _jsEngine.Execute(compilerSource);

            _jsEngine.SetValue("host", Host);
            _jsEngine.Execute("let ls = new ts.createLanguageService(host);");

            var libSourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("TSBridge.TSDefs.lib.d.ts");
            var libSource = ReadStream(libSourceStream);

            Host.RegisterStdLib(libSource);

            //Host.OpenFile(Host.getDefaultLibFileName(CompilerOptions), libSource);
        }

        public async Task LoadComponentsAsync()
        {
            await Task.Run(() => LoadComponents());
        }

        private string ReadStream(Stream stream)
        {
            var value = string.Empty;
            using (stream)
            {
                using (var sourceReader = new StreamReader(stream))
                {
                    value = sourceReader.ReadToEnd();
                }
            }
            return value;
        }

        public void OpenFile(string filename, string text)
        {
            Host.OpenFile(filename, text);
            //create AST from file

            //var ls = _jsEngine.GetValue("ls");

            //string emitOutput = _jsEngine
            //    .Execute("JSON.stringify(ls.getEmitOutput('" + filename.Replace("\\", "\\\\") + "'), null, 4)")
            //    .GetCompletionValue()
            //    .ToObject() as string;
            //JObject treeObj = JObject.Parse(tree);
            //this.SyntaxTree.Clear();
            //this.SyntaxTree.Add(new AstTreeItem(treeObj["sourceUnit"]));
        }

        public string BuildAstJson(string filename, string text)
        {
            //var createSourceFile = _jsEngine.GetValue("ts.createSourceFile");
            //var sourceFileAst = createSourceFile.Invoke(filename, text);
            //var outputJson = JintJson.Stringify(sourceFileAst);

            string outputJson = _jsEngine
                .Execute($"JSON.stringify(ts.createSourceFile('{Regex.Escape(filename)}', '{Regex.Escape(text)}'), null, 4)")
                .GetCompletionValue()
                .ToObject() as string;
            return outputJson;
        }

        public void RemoveFile(string filename)
        {
            Host.RemoveFile(filename);
        }
    }
}