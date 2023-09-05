
using Newtonsoft.Json;
using System;
using System.Windows.Media;

namespace VirtualPhoneNumber.Models
{
    [Serializable]
    public class Number
    {
        public string Service { get; set; }
        public int Country { get; set; }
        public string Operator { get; set; }
        public string Count { get; set; }
        public string Amount { get; set; }
        public string Repeat { get; set; }
        public string Time { get; set; }
        public int Active { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
