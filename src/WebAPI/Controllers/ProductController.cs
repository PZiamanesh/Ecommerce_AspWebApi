using Application.Features.Products.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Common;

namespace WebAPI.Controllers
{
    public class ProductController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> Gets(CancellationToken cancellationToken)
        {
            return Ok(await Sender.Send(new GetAllProductsQuery(), cancellationToken));
        }
    }
}
