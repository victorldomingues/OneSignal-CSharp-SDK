using Newtonsoft.Json;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    public class ActionButtonField
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}