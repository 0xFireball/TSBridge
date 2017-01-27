using Newtonsoft.Json;

namespace TSBridge.Ast.Diagnostics
{
    public class Diagnostic
    {
        public enum DiagnosticCategory
        {
            Warning = 0,
            Error = 1,
            Message = 2,
        }

        [JsonProperty("file")]
        public object File { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("messageText")]
        public string MessageText { get; set; }

        [JsonProperty("category")]
        public DiagnosticCategory Category { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }
}