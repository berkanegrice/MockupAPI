#nullable enable
using System;
using System.Net;
using System.Net.Http;
using Microsoft.VisualBasic.CompilerServices;

namespace MockupAPI.Services
{
    public class PostMethod : IPostMethod
    {
        public object CallPostMethod(string? output, int? httpReturn)
        {
            if (!string.IsNullOrEmpty(output)) return JsonPostMethod(output);
            // ReSharper disable once PossibleInvalidOperationException
            else if (httpReturn != null)
            {
                var (success, httpMessage) = HttpPostMethod((int) httpReturn);
                return success ? httpMessage : "Invalid HttpStatus is given";
            }
            else return "No valid input is given";
        }

        public (bool success, HttpResponseMessage httpMessage) HttpPostMethod(int httpReturn)
        {
            var statusString = Enum.GetName(typeof(HttpStatusCode), httpReturn);
            var success = Enum.TryParse(statusString, out HttpStatusCode returnHttpStatusCode);

            /*
             * If parsed HttpStatusCode is not exist on HttpStatusCode, return 
             * HttpVersionNotSupported.
             */
            return success
                ? (success, new HttpResponseMessage(returnHttpStatusCode))
                : (success, new HttpResponseMessage(HttpStatusCode.HttpVersionNotSupported));
        }

        public string JsonPostMethod(string output)
        {
            // TODO : Add some logic to return coming JSON object.
            return output;
        }
    }
}