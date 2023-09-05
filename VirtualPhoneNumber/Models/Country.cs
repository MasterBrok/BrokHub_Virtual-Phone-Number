
using Newtonsoft.Json;
using System.Windows.Media;

namespace VirtualPhoneNumber.Models
{
    public class Country
    {
        [JsonProperty("id")]
        public int? ID { get; set; }
        /// <summary>
        /// Name Country Anfd Key Resource
        /// </summary>

        [JsonProperty("name_en")]
        public string? Name { get; set; }
        [JsonProperty("image")]
        public string? Image { get; set; }
    }
}
