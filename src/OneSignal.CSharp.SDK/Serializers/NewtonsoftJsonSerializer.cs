using Newtonsoft.Json;
using RestSharp.Serializers;

namespace OneSignal.CSharp.SDK.Serializers
{
    /// <summary>
    /// Custom implementation to Json serializer in order to comply with REST Sharp requirements.
    /// </summary>
    public class NewtonsoftJsonSerializer : ISerializer
    {
        /// <summary>
        /// Content type.
        /// </summary>
        public string ContentType
        {
            get { return "application/json"; }
            set { }
        }

        /// <summary>
        /// Date format.
        /// </summary>
        public string DateFormat { get; set; }

        /// <summary>
        /// Namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Root element.
        /// </summary>
        public string RootElement { get; set; }

        /// <summary>
        /// Serializes object.
        /// </summary>
        /// <param name="obj">Object to serialize.</param>
        /// <returns></returns>
        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Settings);
        }

        /// <summary>
        /// Custom json serializer settings.
        /// </summary>
        private JsonSerializerSettings Settings;

        /// <summary>
        /// Default constructor that prevents null values to be serialized.
        /// </summary>
        public NewtonsoftJsonSerializer()
        {
            Settings = new JsonSerializerSettings();
            Settings.NullValueHandling = NullValueHandling.Ignore;
        }
    }
}
