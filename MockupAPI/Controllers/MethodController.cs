#nullable enable
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using MockupAPI.Services;
using static System.Enum;

namespace MockupAPI.Controllers
{
    public class MethodController : Controller
    {
        private readonly IPostMethod _postMethod;
        public MethodController(IPostMethod postMethod)
        {
            _postMethod = postMethod;
        }
        
        [Route("PostMethod")]
        [HttpPost]
        public object CallPostMethod(string methodName, string? output, int? httpReturn)
        {

            return _postMethod.CallPostMethod(output, httpReturn);
            
        }
    }
}