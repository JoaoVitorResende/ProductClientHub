using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Register([FromBody]RequestClientJson request)
        {

            return Created();
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
