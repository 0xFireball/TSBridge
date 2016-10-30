using Newtonsoft.Json;

namespace TSBridge.LanguageService
{
    public struct TextSpan
    {
        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }
    }
}