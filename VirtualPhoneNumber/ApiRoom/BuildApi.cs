
using System;
using VirtualPhoneNumber.Eunms;
using VirtualPhoneNumber.Models;

namespace VirtualPhoneNumber.ApiRoom
{
    public class BuildApi
    {
        public readonly string? _api = "https://api.numberland.ir/v2.php/?apikey=";
        public readonly string? _key = "7d19d31a70a67f78e2f3c9b4dfc6f520";
        public string? _apiKey;

        public int? id;

        private Method method;
        private Number info;

        public BuildApi(Method method, Number info)
        {
            this.method = method;
            this.info = info;
            _apiKey = _api + _key;

        }

        public BuildApi()
        {
            _apiKey = _api + _key;
        }


        public string Api
        {
            get
            {
                try
                {
                    switch (method)
                    {
                        case Method.getnum:
                            return string.Format("{0}&method={1}&country={2}&operator={3}&service={4}",
                                _apiKey, method,
                                info.Country,
                                info.Operator,
                                info.Service);

                        case Method.getinfo:
                        case Method.getcountry:
                            return string.Format("{0}&method={1}", _apiKey, method);

                        case Method.getinfos:
                            return string.Format("{0}&method={1}&service={2}", 
                                _apiKey, Method.getinfo,info.Service);

                        case Method.checkstatus:
                            return string.Format("{0}&method={1}&id={2}", _apiKey, method, id);
                        default:
                            return string.Empty;
                    }
                }
                catch (Exception)
                {
                    return "Error";
                }
            }
        }

    }
}
