using ApiAlegra.Dto.Request;
using ApiAlegra.Service;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiAlegra.Controllers
{
    [ApiController]
    [Route("api/alegracliente")]
    public class PersonaController : ControllerBase
    {

        private readonly PersonaService _personaService;
        public PersonaController(PersonaService personaService)
        {
            _personaService = personaService;
        }


        [HttpPost("crear")]
        public async Task<IActionResult> CrearCliente(
            [FromHeader] string usuario,
            [FromHeader] string token,
            [FromBody] CrearClienteRequest RequestCliente)
        {


            var result = await _personaService.CrearPersona(usuario, token, RequestCliente);


            if (!string.IsNullOrEmpty(result.ErrorMessage))
            {
                return StatusCode(500, new { message = result.ErrorMessage });
            }

            if (result.Success && result.Content != null)
            {
                return StatusCode(200, JsonSerializer.Deserialize<object>(result.Content));
            }
            else
            {
                return StatusCode(400, JsonSerializer.Deserialize<object>(result.Content));
            }

            

        }


        [HttpGet("doc/{documento}")]
        public async Task<IActionResult> ConsultarClienteDoc(
              [FromHeader] string usuario,
              [FromHeader] string token,
              string documento
            )
        {
            var result = await _personaService.ConsultarPersonaDocumento(usuario, token, documento);

            if (!string.IsNullOrEmpty(result.ErrorMessage))
            {
                return StatusCode(500, new { message = result.ErrorMessage });
            }

            if (result.Success && result.Content != null)
            {
                return StatusCode(200, JsonSerializer.Deserialize<object>(result.Content));
            }
            else
            {
                return StatusCode(400, JsonSerializer.Deserialize<object>(result.Content));
            }

            return StatusCode(500);
        }


        [HttpGet]
        public async Task<IActionResult> ConsultarCliente(
              [FromHeader] string usuario,
              [FromHeader] string token

            )
        {
            var result = await _personaService.ConsultarPersona(usuario, token);

            if (!string.IsNullOrEmpty(result.ErrorMessage))
            {
                return StatusCode(500, new { message = result.ErrorMessage });
            }

            if (result.Success && result.Content != null)
            {
                return StatusCode(200, JsonSerializer.Deserialize<object>(result.Content));
            }
            else
            {
                return StatusCode(400, JsonSerializer.Deserialize<object>(result.Content));
            }

            return StatusCode(500);
        }


    }
}
