using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerSaradnja : ControllerBase
    {
        [HttpPost]
        [Route("SaradnjaAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaradnjaAdd([FromBody] DTOSaradnjaDodajj saradnja)
        {
            try
            {
                await DTOManager.SaradnjaDodajj(saradnja);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazSaradnji")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PrikazSaradnji()
        {
            try
            {
                return new JsonResult(await DTOManager.SaradnjeVratii());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("SaradnjaPrikaz/{saradnjaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaradnjaPrikaz(int saradnjaId)
        {
            try
            {
                return new JsonResult(await DTOManager.SaradnjeVratiPoId(saradnjaId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("SaradnjaDelete/{saradnjaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaradnjaObrisii(int saradnjaId)
        {
            try
            {
                await DTOManager.SaradnjaObrisii(saradnjaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("SaradnjaChange/{saradnjaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaradnjaIzmenii([FromBody] DTOSaradnjaDodajj sertifikat, int saradnjaId)
        {
            try
            {
                await DTOManager.SaradnjaIzmenii(sertifikat, saradnjaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
