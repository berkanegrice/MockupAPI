#nullable enable
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Mockup.Application.Interfaces;
using Mockup.Domain.Enums;
using Mockup.Domain.Entity;
using AutoMapper;

namespace Mockup.Application.Commands
{
    public class CreateEndpointCommand : IRequest<object>
    {
        public RequestType Request { get; set; }
        public string? Output { get; set; }
        public int HttpReturnCode { get; set; }
    }

    public class CreateEndpointCommandHandler : IRequestHandler<CreateEndpointCommand, object>
    {
        private readonly IMethodFactory _methodFactory;
        private readonly IMapper _mapper;

        public CreateEndpointCommandHandler(IMethodFactory methodFactory, IMapper mapper)
        {
            _methodFactory = methodFactory;
            _mapper = mapper;
        }

        public async Task<object> Handle(CreateEndpointCommand request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Endpoint>(request);

            return await Task.FromResult(_methodFactory.Request(model));
        }
    }
}
