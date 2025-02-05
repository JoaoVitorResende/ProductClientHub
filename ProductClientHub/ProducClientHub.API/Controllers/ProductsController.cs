using Microsoft.AspNetCore.Mvc;
using ProducClientHub.API.UseCases.Products.Register;
using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;

namespace ProducClientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        [Route("{clientId}")]
        [ProducesResponseType(typeof(ResponseShortProductJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseShortProductJson), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromRoute] Guid clientId, [FromBody] RequestProductJson request)
        {
            var useCase = new RegisterProductUseCase();
            var response = useCase.Execute(clientId, request);
            return Created(string.Empty, response);
        }
    }
}
