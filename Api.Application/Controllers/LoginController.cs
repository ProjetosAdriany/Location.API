using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.DTOs;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        //FromService = Injeção de dependência
        public async Task<object> Login([FromBody] LoginDTO login, [FromServices] ILoginService service)
        {
            if (!ModelState.IsValid || login == null)
                return BadRequest();

            try
            {
                var result = await service.findByEmail(login);
                if (result == null)
                    return NotFound();

                return Ok(result);

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
