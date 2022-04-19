#nullable enable
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using Mockup.Application.Commands;
using Mockup.Web.Controllers;

namespace Mockup.Web
{
    public class MethodController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<object>> CallPostMethod(CreateEndpointCommand command)
        {
            command.Request = Domain.Enums.RequestType.Post;
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<object>> CallGetMethod(CreateEndpointCommand command)
        {
            command.Request = Domain.Enums.RequestType.Get;
            return await Mediator.Send(command);
        }
    }
}