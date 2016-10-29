using Jint;
using Jint.Native;

namespace TSBridge.JSUtils
{
    public static class JintJson
    {
        private static Engine _jjsonEngine = new Engine();
        private static JsValue _stringify;
        private static JsValue _parse;

        static JintJson()
        {
            _stringify = _jjsonEngine.GetValue("JSON.stringify");
            _parse = _jjsonEngine.GetValue("JSON.parse");
        }

        public static string Stringify(JsValue nativeJsValue)
        {
            return _stringify.Invoke(nativeJsValue).AsString();
        }

        public static JsValue Parse(string json)
        {
            return _parse.Invoke(json);
        }
    }
}