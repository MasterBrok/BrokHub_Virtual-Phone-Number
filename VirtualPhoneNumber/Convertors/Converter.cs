// DLL
using Newtonsoft.Json;
// System
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace VirtualPhoneNumber.Convertors
{
    [Serializable]
    public class Converter<T>
    {
        public static ObservableCollection<T> Converts(string json)
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using StringReader reader = new StringReader(json);
                using var jsonReader = new JsonTextReader(reader);
                return serializer.Deserialize<ObservableCollection<T>>(jsonReader);

            }
            catch
            {
                throw new JsonException("T Value Is Not Validate");
            }
        }

        public static T Convert(string json)
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using StringReader reader = new StringReader(json);
                using var jsonReader = new JsonTextReader(reader);
                return serializer.Deserialize<T>(jsonReader);
            }
            catch
            {
                throw new JsonException("T Value Is Not Validate");
            }
        }
    }
}
