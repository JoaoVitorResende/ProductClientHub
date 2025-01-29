﻿using Microsoft.AspNetCore.Mvc;

namespace ProducClientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register()
        {
            return Ok();
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
        public IActionResult GetById(Guid id)
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
