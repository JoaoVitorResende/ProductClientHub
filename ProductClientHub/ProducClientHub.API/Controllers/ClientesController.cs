using Microsoft.AspNetCore.Mvc;
using ProducClientHub.API.UseCases.Clients.Register;
using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;

namespace ProducClientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody]RequestClientJson request)
        {
            try
            {
                var useCase = new RegisterClientUseCase();
                var response = useCase.Execute(request);
                return Created(string.Empty, response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new ResponseErrorMessagesJson(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseErrorMessagesJson("Erro desconhecido"));
            }
        }
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromBody] Guid id)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
