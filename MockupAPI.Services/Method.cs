#nullable enable
using System;
using System.Net;
using System.Net.Http;

namespace MockupAPI.Services
{
    public class Method : IMethod
    {
        public object Request(string? output, int? httpReturn){

            if (!string.IsNullOrEmpty(output)) return ReturnJsonMethod(output);
            // ReSharper disable once PossibleInvalidOperationException
            else if (httpReturn != null)
            {
                var (success, httpMessage) = ReturnHttpStatusResponse((int) httpReturn);
                return success ? httpMessage : "Invalid HttpStatus is given";
            }
            else return "No valid input is given";
        }
        public (bool success, HttpResponseMessage httpMessage) ReturnHttpStatusResponse(int httpReturn)
        {
            var statusString = Enum.GetName(typeof(HttpStatusCode), httpReturn);
            var success = Enum.TryParse(statusString, out HttpStatusCode returnHttpStatusCode);

            /*
             * If parsed HttpStatusCode is not exist on HttpStatusCode, return 
             * empty HttpResponseMessage.
             */
            return success
                ? (success, new HttpResponseMessage(returnHttpStatusCode))
                : (success, new HttpResponseMessage());
        }

        public string ReturnJsonMethod(string output)
        {
            // Are we need any implementation in here ?
            return output;
        }
    }
}