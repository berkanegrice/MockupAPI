using System.Net.Http;

#nullable enable
namespace MockupAPI.Services
{
    public interface IPostMethod
    {
        public object MethodIsCalled(string? output, int? httpReturn);        
        public (bool success, HttpResponseMessage httpMessage) ReturnHttpStatusResponse(int httpReturn);
        public string ReturnJsonMethod(string output);
    }
}