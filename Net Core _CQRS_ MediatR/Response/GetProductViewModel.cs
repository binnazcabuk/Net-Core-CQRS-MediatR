using System;

namespace Net_Core__CQRS__MediatR.Response
{
    public class GetProductViewModel
    {
        public Guid id { get; set; }
        public string name { get; set; }
    }
}
