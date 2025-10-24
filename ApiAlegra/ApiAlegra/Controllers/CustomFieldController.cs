using ApiAlegra.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlegra.Controllers
{
    [ApiController]
    [Route("api/alegracustomfield")]
    public class CustomFieldController : ControllerBase
    {
        private readonly CustomFieldService _customFieldService;
        public CustomFieldController(CustomFieldService customFieldService)
        {
            _customFieldService = customFieldService;
        }


        [HttpGet]
        public async Task<IActionResult> ConsultarCustomFields(
            [FromHeader] string usuario,
            [FromHeader] string token
            )
        {
            var result = await _customFieldService.ConsultarCustomFields(usuario, token);
            if (!string.IsNullOrEmpty(result.ErrorMessage))
            {
                return StatusCode(500, new { message = result.ErrorMessage });
            }
            if (result.Success && result.Content != null)
            {
                return StatusCode(200, System.Text.Json.JsonSerializer.Deserialize<object>(result.Content));
            }
            else
            {
                return StatusCode(400, System.Text.Json.JsonSerializer.Deserialize<object>(result.Content));
            }


        }
    }
}
