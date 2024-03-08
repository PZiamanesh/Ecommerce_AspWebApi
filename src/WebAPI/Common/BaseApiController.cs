using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Common
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private ISender _sender = null;
        protected ISender Sender => _sender ?? HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
