#nullable enable
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MockupAPI.Services;

namespace MockupAPI.Controllers
{
    public class MethodController : Controller
    {
        private readonly IMethod _Method;
        private readonly IScaffoldMethod _ScaffoldMethod;
        public MethodController(IMethod Method, IScaffoldMethod ScaffoldMethod)
        {
            _Method = Method;
            _ScaffoldMethod = ScaffoldMethod;
        }
        
        [Route("PostMethod")]
        [HttpPost]
        public object CallPostMethod(string? methodName, string? output, int? httpReturn)
            => _Method.MethodIsCalled(output, httpReturn);    

        [Route("GetMethod")]
        [HttpGet]
        public object CallGetMethod(string? methodName, string? output, int? httpReturn)
            => _Method.MethodIsCalled(output, httpReturn);    

        [Route("GetMethodScaffold")]
        [HttpGet]
        public void CreateGetMethod(string methodName) 
        {
            // string ServiceAdress, List<Field> ReturnClassFields, object[] ReturnClassFieldValue
            var fieldList = new List<Field>(){
                new Field("EmployeeID", typeof(int)),
                new Field("EmployeeName", typeof(string)),
                new Field("Designation", typeof(string)) 
            };
            var ob = new object[]{ 123456, "John", "Thech Lead" };
            _ScaffoldMethod.CreateScaffoldMethod("someServices", fieldList, ob);
        }
    }
}