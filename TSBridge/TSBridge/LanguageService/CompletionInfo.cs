using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSBridge.LanguageService
{
    public class CompletionInfo
    {
        [JsonProperty("isGlobalCompletion")]
        public bool IsGlobalCompletion { get; set; }

        [JsonProperty("isMemberCompletion")]
        public bool IsMemberCompletion { get; set; }

        [JsonProperty("isNewIdentifierLocation")]
        public bool IsNewIdentifierLocation { get; set; }

        [JsonProperty("entries")]
        public IEnumerable<CompletionEntry> Entries { get; set; }
    }
}