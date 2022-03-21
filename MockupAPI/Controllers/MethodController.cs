#nullable enable
using Microsoft.AspNetCore.Mvc;
using MockupAPI.Services;

namespace MockupAPI.Controllers
{
    public class MethodController : Controller
    {
        private readonly IMethod _Method;
        public MethodController(IMethod Method)
        {
            _Method = Method;
        }
        
        [Route("PostMethod")]
        [HttpPost]
        public object CallPostMethod(string? methodName, string? output, int? httpReturn)
            => _Method.Request(output, httpReturn);    

        [Route("GetMethod")]
        [HttpGet]
        public object CallGetMethod(string? methodName, string? output, int? httpReturn)
            => _Method.Request(output, httpReturn);    
    }
}