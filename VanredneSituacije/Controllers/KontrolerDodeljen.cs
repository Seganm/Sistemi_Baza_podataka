using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;
namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerDodeljen : ControllerBase
    {
        [HttpPost]
        [Route("DodeljenoDodaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DodeljenDodaj([FromBody] DTODodajDodeljen dodeljen)
        {
            try
            {
                await DTOManager.DodajDodeljivanje(dodeljen);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("DodeljenaVrati")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DodeljenaVrati()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSvaDodeljivanja());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("DodeljenoVrati/{dodeljenId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DodeljenoVrati(int dodeljenId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiDodeljivanje(dodeljenId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("DodeljenoObrisi/{dodeljenId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DodeljenObrisi(int dodeljenId)
        {
            try
            {
                await DTOManager.ObrisiDodeljivanje(dodeljenId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("DodeljenoIzmeni/{dodeljenId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DodeljenIzmeni([FromBody] DTODodajDodeljen dodeljen, int dodeljenId)
        {
            try
            {
                await DTOManager.IzmeniDodeljujeSe(dodeljen, dodeljenId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

       

       
    }
}
