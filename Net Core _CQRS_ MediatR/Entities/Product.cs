using System;

namespace Net_Core__CQRS__MediatR.Entities
{
    public class Product
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public decimal amount{ get; set; }

    }
}
