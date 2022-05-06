using Mockup.Domain.Enums;

namespace Mockup.Domain.Entity
{
    public class Endpoint
    {
        public RequestType RequestType { get; set; }
        public string? Output { get; set; }
        public int? HttpReturnCode { get; set; }
    }
}
