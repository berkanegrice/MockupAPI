#nullable enable
using Mockup.Application.Interfaces;
using Mockup.Domain.Entity;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mockup.Infrastructure.Files
{
    public class Method : IMethodFactory
    {
        public object Request(Mockup.Domain.Entity.Endpoint endPoint){

            var output = endPoint.Output;
            var httpReturn = endPoint.HttpReturnCode;

            if (!string.IsNullOrEmpty(output)) return ReturnJsonMethod(output);
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

        Task<object> IMethodFactory.Request(Endpoint endpoint)
        {
            throw new NotImplementedException();
        }
    }
}