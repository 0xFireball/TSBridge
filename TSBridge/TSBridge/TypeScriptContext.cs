using Jint;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using TSBridge.Services;

namespace TSBridge
{
    public class TypeScriptContext
    {
        private Engine _jsEngine;
        public LanguageServiceHost Host { get; set; }

        public TypeScriptContext()
        {
            _jsEngine = new Engine(x => { x.AllowClr(typeof(TypeScriptContext).Assembly); });
        }

        public void LoadComponents()
        {
            // Load the compiler services
            var compilerSourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("TSBridge.JS.typescriptServices.js");
            var compilerSource = ReadStream(compilerSourceStream);
            _jsEngine.Execute(compilerSource);

            //var tsCompilerObj = _jsEngine.GetValue("ts").AsObject();
            Host = new LanguageServiceHost(new NullLogger());
            _jsEngine.SetValue("host", Host);
            _jsEngine.Execute("let ls = new ts.createLanguageService(host);");
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

            string emitOutput = _jsEngine
                .Execute("JSON.stringify(ls.getEmitOutput('" + filename.Replace("\\", "\\\\") + "'), null, 4)")
                .GetCompletionValue()
                .ToObject() as string;
            //JObject treeObj = JObject.Parse(tree);
            //this.SyntaxTree.Clear();
            //this.SyntaxTree.Add(new AstTreeItem(treeObj["sourceUnit"]));
        }

        public void RemoveFile(string filename)
        {
            Host.RemoveFile(filename);
        }
    }
}