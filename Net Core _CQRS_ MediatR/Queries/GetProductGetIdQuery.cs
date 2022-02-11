using MediatR;
using Net_Core__CQRS__MediatR.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Net_Core__CQRS__MediatR.Queries
{
    
    ///Bu query çalıştığında IRequest içinde Response olarak hangi view’i döneceğini söylüyoruz.IRequest mediatR kütüphanesinden gelir.
    public class GetProductGetIdQuery:IRequest<GetProductViewModel>
    {
        public Guid id { get; set; }

        /// GetProductGetIdQuery çağrıldığında yapılacak işlemi handle metodunda tanımlıyoruz

        ///  IRequestHandler içinde hangi query’i handle edeceğimizi ve Response olarak ne   döneceğimizi belirtiyoruz.       

        ///  IRequestHandler’dan bize Handle metodu otomatik geliyor.

        public class GetProductGetIdQueryHandler : IRequestHandler<GetProductGetIdQuery, GetProductViewModel>
        {
            public Task<GetProductViewModel> Handle(GetProductGetIdQuery request, CancellationToken cancellationToken)
            {
                ///  Şuan bir veri tabanı olmadığı için manuel bir veri döndük veri tabanı  olduğun da ilgili context’i tanımlayıp onu kullanıp veriyi dönecektik.

                var viewModel = new GetProductViewModel()
                {
                    id=Guid.NewGuid(),
                    name="Kitap"
                };

                return Task.FromResult(viewModel);
            }
        }
    }
}
