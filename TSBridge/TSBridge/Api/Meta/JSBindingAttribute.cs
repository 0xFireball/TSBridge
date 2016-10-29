using System;

namespace TSBridge.Api.Meta
{
    public class JSBindingAttribute : Attribute
    {
        public string MethodName { get; set; }

        public JSBindingAttribute(string method)
        {
            MethodName = method;
        }
    }
}