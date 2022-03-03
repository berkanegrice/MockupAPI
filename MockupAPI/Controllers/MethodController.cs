#nullable enable
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using static System.Enum;

namespace MockupAPI.Controllers
{
    public class MethodController : Controller
    {
        [Route("PostMethod")]
        [HttpPost]
        public object CallPostMethod(string methodName, string? output, int? httpReturn)
        {
            if (!httpReturn.HasValue) return !string.IsNullOrEmpty(output) ? output : "No valid input is given";
            
            var statusString = GetName(typeof(HttpStatusCode), httpReturn);
            var success = TryParse(statusString, out HttpStatusCode returnHttpStatusCode);
            
            return success ? new HttpResponseMessage(returnHttpStatusCode) : "HttpStatus code is not valid";
        }
    }
}