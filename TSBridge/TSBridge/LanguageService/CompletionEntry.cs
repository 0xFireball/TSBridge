using Newtonsoft.Json;

namespace TSBridge.LanguageService
{
    public class CompletionEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("kindModifiers")]
        public string KindModifiers { get; set; }

        [JsonProperty("sortText")]
        public string SortText { get; set; }

        [JsonProperty("replacementSpan")]
        public TextSpan ReplacementSpan { get; set; }
    }
}