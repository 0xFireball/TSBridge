using System;
using TSBridge.Api.Meta;

namespace TSBridge.Api
{
    public class TypeScriptLanguageService : ITypeScriptLanguageService
    {
        private object _jsHandle;

        public TypeScriptLanguageService(object jsHandle)
        {
            _jsHandle = jsHandle;
        }

        [JSBinding("getProgram")]
        public string GetProgram()
        {
            throw new NotImplementedException();
        }
    }
}