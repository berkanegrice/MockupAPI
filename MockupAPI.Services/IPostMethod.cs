using System.Net.Http;

#nullable enable
namespace MockupAPI.Services
{
    public interface IPostMethod
    {
        public object CallPostMethod(string? output, int? httpReturn);
        
        public (bool success, HttpResponseMessage httpMessage) HttpPostMethod(int httpReturn);
        public string JsonPostMethod(string output);
    }
}