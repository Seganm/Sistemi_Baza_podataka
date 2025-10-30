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
        public async Task<IActionResult> SaradnjaAdd([FromBody] DTODodajSaradnju saradnja)
        {
            try
            {
                await DTOManager.DodajSaradnju(saradnja);
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
                return new JsonResult(await DTOManager.VratiSaradnje());
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
                return new JsonResult(await DTOManager.VratiSaradnju(saradnjaId));
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
        public async Task<IActionResult> ObrisiSaradnju(int saradnjaId)
        {
            try
            {
                await DTOManager.ObrisiSaradnju(saradnjaId);
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
        public async Task<IActionResult> IzmeniSaradnju([FromBody] DTODodajSaradnju sertifikat, int saradnjaId)
        {
            try
            {
                await DTOManager.IzmeniSaradnju(sertifikat, saradnjaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
