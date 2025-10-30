using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerAngazovano : ControllerBase
    {
        [HttpPost]
        [Route("AngazovanoAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AngazovanoAdd([FromBody] DTODodajAngazovano angazovano)
        {
            try
            {
                await DTOManager.DodajUcestvovanje(angazovano);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazAngazovanih")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PrikazAngazovanih()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiUcestvovanja());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikaziAngazovanje/{angazovanoId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PrikaziAngazovanje(int angazovanoId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiUcestvovanje(angazovanoId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("AngazovanoDelete/{angazovanoId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AngazovanoDelete(int angazovanoId)
        {
            try
            {
                await DTOManager.ObrisiUcestvovanje(angazovanoId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AngazovanoChange/{angazovanoId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AngazovanoChange([FromBody] DTODodajAngazovano angazovano, int angazovanoId)
        {
            try
            {
                await DTOManager.IzmeniUcestvovanje(angazovano, angazovanoId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
       
    }
}
