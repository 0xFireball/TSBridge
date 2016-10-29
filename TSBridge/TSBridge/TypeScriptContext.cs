using Jint;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace TSBridge
{
    public class TypeScriptContext
    {
        private Engine _jsEngine;

        public TypeScriptContext()
        {
            _jsEngine = new Engine();
        }

        public async Task LoadComponents()
        {
            // Load the compiler services
            var compilerSourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("TSBridge.JS.typescriptServices.js");
            var compilerSource = ReadStream(compilerSourceStream);
            _jsEngine.Execute(compilerSource);
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
    }
}