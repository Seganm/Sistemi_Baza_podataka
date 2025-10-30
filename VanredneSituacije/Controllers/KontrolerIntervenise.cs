using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerIntervenise : ControllerBase
    {
        [HttpPost]
        [Route("InterveniseAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> InterveniseAdd([FromBody] DTODodajIntervenise intervenise)
        {
            try
            {
                await DTOManager.DodajUcestvuje(intervenise);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazIntervenisanja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PrikazIntervenisanja()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSvaUcestvovanja());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikaziIntervenisanje/{interveniseId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PrikaziIntervenisanje(int interveniseId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiUcestvuje(interveniseId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("InterveniseDelete/{interveniseId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> InterveniseDelete(int interveniseId)
        {
            try
            {
                await DTOManager.ObrisiUcestvuje(interveniseId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("InterveniseChange/{interveniseId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> InterveniseChange([FromBody] DTODodajIntervenise intervenise, int interveniseId)
        {
            try
            {
                await DTOManager.IzmeniUcestvuje(intervenise, interveniseId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
   
    }
}
