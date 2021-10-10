using System.Threading.Tasks;
using Application.Features.Countries.Commands.CreateCountry;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers.v1.Order
{
    [ApiVersion("1.0")]
    public class CountryController : BaseApiController
    {
        // POST api/<controller>
        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Post(CreateCountryCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
