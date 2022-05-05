#nullable enable
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Mockup.Application.Commands;

namespace Mockup.Web.Controllers
{
    public class MethodController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<object>> CallPostMethod(EndpointCommand command)
        {
            var createEndpoint = new CreateEndpointCommand()
            {
                Output = command.Output,
                RequestType = Domain.Enums.RequestType.Post,
                HttpReturnCode = command.HttpReturnCode
            };
             
            return await Mediator.Send(createEndpoint);
        }

        [HttpGet]
        public async Task<ActionResult<object>> CallGetMethod(EndpointCommand command)
        {
            var createEndpoint = new CreateEndpointCommand()
            {
                Output = command.Output,
                RequestType = Domain.Enums.RequestType.Get,
                HttpReturnCode = command.HttpReturnCode
            };
             
            return await Mediator.Send(createEndpoint);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult<object>> CallMethod(CreateEndpointCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}