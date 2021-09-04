using System.Threading.Tasks;
using Application.Features.Orders.Commands.CreateOrder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers.v1.Order
{
    [ApiVersion("1.0")]
    public class OrderController : BaseApiController
    {        
        // POST api/<controller>
        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Post(CreateOrderCommand command)
        {
            return Ok(await Mediator.Send(command));
        }       
    }
}
