#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mockup.Domain.Enums;

namespace Mockup.Domain.Entity
{
    public class Endpoint
    {
        public RequestType Request;
        public string? Output { get; set; }
        public int? HttpReturnCode { get; set; }
    }
}
