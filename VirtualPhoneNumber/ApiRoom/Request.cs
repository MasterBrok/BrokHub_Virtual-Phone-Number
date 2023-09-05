
using System.Net.Http;
using System.Threading.Tasks;
using VirtualPhoneNumber.Eunms;
using VirtualPhoneNumber.Exceptions;
using VirtualPhoneNumber.Models;

namespace VirtualPhoneNumber.ApiRoom
{
    public class Request
    {

        public Number number { get; set; }
        public Method method { get; set; }

        public Request(Number number, Method method)
        {
            this.number = number;
            this.method = method;
        }

        public Request()
        {

        }

        public async Task<string> Get()
        {
            try
            {
                using HttpClient? client = new();
                var result = await client.GetAsync(new BuildApi(method, number).Api);
                var values = result.Content.ReadAsStringAsync();
                return await values;
            }
            catch
            {
                throw new ApiException("Api Key");
            }
        }


    }
}
