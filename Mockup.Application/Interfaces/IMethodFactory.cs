using System.Net.Http;
using System.Threading.Tasks;

#nullable enable
namespace Mockup.Application.Interfaces
{
    public interface IMethodFactory
    {
        public Task<object> Request(Mockup.Domain.Entity.Endpoint endpoint);        
        public (bool success, HttpResponseMessage httpMessage) ReturnHttpStatusResponse(int httpReturn);
        public string ReturnJsonMethod(string output);
    }
}