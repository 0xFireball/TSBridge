using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSBridge.Ast
{
    public class TypeScriptSyntaxTree : Declaration
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("bindDiagnostics")]
        public object[] BindDiagnostics { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("languageVariant")]
        public LanguageVariant LanguageVariant { get; set; }

        [JsonProperty("isDeclarationFile")]
        public bool IsDeclarationFile { get; set; }

        [JsonProperty("scriptKind")]
        public ScriptKind ScriptKind { get; set; }

        [JsonProperty("referencedFiles")]
        public string[] ReferencedFiles { get; set; }

        [JsonProperty("typeReferenceDirectives")]
        public string[] TypeReferenceDirectives { get; set; }

        [JsonProperty("amdDependencies")]
        public string[] AmdDependencies { get; set; }

        [JsonProperty("statements")]
        public NodeArray<IStatement> Statements { get; set; }

        [JsonProperty("endOfFileToken")]
        public Token EndOfFileToken { get; set; }

        [JsonProperty("nodeCount")]
        public int NodeCount { get; set; }

        [JsonProperty("statements")]
        public int IdentifierCount { get; set; }

        [JsonProperty("identifiers")]
        public Dictionary<string, string> Identifiers { get; set; }

        [JsonProperty("parseDiagnostics")]
        public object ParseDiagnostics { get; set; }
    }
}