using System.Net.Http;

#nullable enable
namespace Mockup.Application.Interfaces
{
    public interface IMethodFactory
    {
        public object Request(string? output, int? httpReturn);        
        public (bool success, HttpResponseMessage httpMessage) ReturnHttpStatusResponse(int httpReturn);
        public string ReturnJsonMethod(string output);
    }
}