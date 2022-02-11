using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Net_Core__CQRS__MediatR.Commands
{
    public class CreateProductCommand:IRequest<Guid>
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public decimal value { get; set; }

        /// bu command çağrılınca çalışacak handler
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {           
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {

                return Task.FromResult(Guid.NewGuid());
            }
        }
    }
}
