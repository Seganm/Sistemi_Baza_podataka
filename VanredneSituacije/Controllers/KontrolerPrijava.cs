using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerPrijava : ControllerBase
    {
        [HttpPost]
        [Route("PrijavaAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PrijavaAdd([FromBody] DTODodajPrijavu prijava)
        {
            try
            {
                await DTOManager.DodajPrijavu(prijava);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazPrijava")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> PrikazPrijava()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiPrijave());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("PrijavaDelete/{prijavaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PrijavaDelete(int prijavaId)
        {
            try
            {
                await DTOManager.ObrisiPrijavu(prijavaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }



        [HttpPut]
        [Route("PrijavaChange/{prijavaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrijavaChange([FromBody] DTODodajPrijavu prijava, int prijavaId)
        {
            try
            {
                await DTOManager.IzmeniPrijavu(prijava, prijavaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
