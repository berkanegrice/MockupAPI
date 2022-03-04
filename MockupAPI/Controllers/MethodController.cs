#nullable enable
using Microsoft.AspNetCore.Mvc;
using MockupAPI.Services;

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
        public object CallPostMethod(string? methodName, string? output, int? httpReturn)
            => _postMethod.MethodIsCalled(output, httpReturn);    

        [Route("GetMethod")]
        [HttpGet]
        public object CallGetMethod(string? methodName, string? output, int? httpReturn)
            => _postMethod.MethodIsCalled(output, httpReturn);    
    }
}