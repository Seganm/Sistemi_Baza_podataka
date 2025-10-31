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
                await DTOManager.InterveniseDodajj(intervenise);
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
                return new JsonResult(await DTOManager.UcestvovanjaVratii());
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
                return new JsonResult(await DTOManager.InterveniseVratii(interveniseId));
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
                await DTOManager.InterveniseObrisii(interveniseId);
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
                await DTOManager.InterveniseIzmenii(intervenise, interveniseId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
   
    }
}
