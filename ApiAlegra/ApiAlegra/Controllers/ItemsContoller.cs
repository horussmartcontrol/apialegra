using ApiAlegra.Dto.Request;
using ApiAlegra.Service;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiAlegra.Controllers
{
    [ApiController]
    [Route("api/alegraitem")]
    public class ItemsContoller : ControllerBase
    {
        private readonly ItemsService _inventarioService;

        public ItemsContoller(ItemsService inventarioService)
        {
            _inventarioService = inventarioService;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarItems(
            [FromHeader] string usuario,
            [FromHeader] string token
            )
        {
            var result = await _inventarioService.ConsultarItems(usuario, token);

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


        [HttpPost("Crear")]
        public async Task<IActionResult> CrearItems(
            [FromHeader] string usuario,
            [FromHeader] string token,
            [FromBody] CrearItemsRequest itemsRequest
            )
        {
            var result = await _inventarioService.CrearItems(usuario, token, itemsRequest);

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
    }
}
