using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerZaliha : ControllerBase
    {
        [HttpPost]
        [Route("ZalihaAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ZalihaAdd([FromBody] DTODodajZalihe zaliha)
        {
            try
            {
                await DTOManager.DodajZalihe(zaliha);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazZaliha")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazZaliha()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiZalihe());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikaziZalihu/{broj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikaziZalihu(string broj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiZalihe(broj));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpDelete]
        [Route("ZalihaDelete/{broj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ZalihaDelete(string broj)
        {
            try
            {
                await DTOManager.ObrisiZalihe(broj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut]
        [Route("ZalihaChange/{broj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ZalihaChange(string broj, [FromBody] DTODodajZalihe zaliha)
        {
            try
            {
                await DTOManager.IzmeniZalihe(zaliha, broj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
