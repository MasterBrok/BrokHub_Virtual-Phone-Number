using System;

namespace VirtualPhoneNumber.Exceptions
{
    [Serializable]
    public class ApiException : Exception
    {
        string? TitleMessage = "Error Api.";
        public ApiException() : base()
        {
                
        }
        public ApiException(string message) : base(String.Format("Api is Noy Validate : {0}",message))
        {
                
        }

        public ApiException(string message,Exception exception) : base(String.Format("Api is Noy Validate : {0}", message), exception)
        {

        }
    }
}
