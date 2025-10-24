using ApiAlegra.Dto.Request;
using ApiAlegra.Service;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiAlegra.Controllers
{
    [ApiController]
    [Route("api/alegrafactura")]
    public class FacturaController : ControllerBase
    {
        private readonly FacturaService _facturaService;
        public FacturaController(FacturaService facturaService)
        {
            _facturaService = facturaService;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearFactura(
            [FromHeader] string usuario,
            [FromHeader] string tkn,
            [FromBody] CrearFacturaRequest facturaRequest
            )
        {
            var result = await _facturaService.CrearFactura(usuario, tkn, facturaRequest);

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

        [HttpGet("colsultar")]
        public async Task<IActionResult> ConsultarFactura(
            [FromHeader] string usuario,
            [FromHeader] string tkn
           )
        {
            var result = await _facturaService.ConsultarFactura(usuario, tkn);

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


        [HttpGet("consultar{fecha}")]
        public async Task<IActionResult> ConsultarFacturaFecha(
        [FromHeader] string usuario,
        [FromHeader] string tkn,
        string fecha
       )
        {
            var result = await _facturaService.ConsultarFacturaFecha(usuario, tkn, fecha);

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
