using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net_Core__CQRS__MediatR.Commands;
using Net_Core__CQRS__MediatR.Queries;
using System;
using System.Threading.Tasks;

namespace Net_Core__CQRS__MediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator=mediator;
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetProductGetIdQuery() { id=id };
            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand createProduct)
        {
            return Ok(await mediator.Send(createProduct));
        }
    }
}
