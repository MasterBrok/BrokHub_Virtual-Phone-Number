
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using VirtualPhoneNumber.Models;

namespace VirtualPhoneNumber.Brok
{
    public class BrokNumber
    {
        public ApiRoom.Request Request;
        public BrokNumber()
        {

        }


        public async ValueTask<ObservableCollection<Country>> GetCountry()
        {
            try
            {
                Request.method = Eunms.Method.getcountry;
                return Convertors.Converter<Country>.Converts(await Request.Get());
               
            }
            catch
            {
                throw new Exception("Error (Numbers)");
            }
        }

        public async ValueTask<ObservableCollection<Number>> GetNumbers()
        {
            try
            {
                return Convertors.Converter<Number>.Converts(await Request.Get());
            }
            catch
            {
                throw new Exception("Error (Numbers)");
            }
        }

        public async ValueTask<Number> GetNumber()
        {
            try
            {
                return Convertors.Converter<Number>.Convert(await Request.Get());
            }
            catch
            {
                throw new Exception("Error (Number)");
            }
        }

    }
}
