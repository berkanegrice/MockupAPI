using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Mockup.Application.Interfaces;
using Mockup.Domain.Entity;
using AutoMapper;
using Mockup.Application.Mappings;
using Mockup.Domain.Enums;

namespace Mockup.Application.Commands
{
    public class EndpointCommand
    {
        public string? Output { get; set; }
        public int? HttpReturnCode { get; set; }
    }

    public class CreateEndpointCommand : IRequest<object>, IMapFrom<CreateEndpointCommand>
    {
        public RequestType RequestType { get; set; }
        public string? Output { get; set; }
        public int? HttpReturnCode { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Endpoint, CreateEndpointCommand>().ReverseMap();
        }
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
