using System.Net.Http;
using System.Threading.Tasks;

namespace Mockup.Application.Interfaces
{
    public interface IMethodFactory
    {
        public object Request(Mockup.Domain.Entity.Endpoint endpoint);        
        public (bool success, HttpResponseMessage httpMessage) ReturnHttpStatusResponse(int httpReturn);
        public string ReturnJsonMethod(string output);
    }
}