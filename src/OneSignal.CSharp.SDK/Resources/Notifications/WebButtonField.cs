using Newtonsoft.Json;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    public class WebButtonField
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}