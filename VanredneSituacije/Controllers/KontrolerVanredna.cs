using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerVanredna : ControllerBase
    {
        [HttpPost]
        [Route("VanrednaAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        public async Task<IActionResult> VanrednaAdd([FromBody] DTODodajVanrednuSituaciju vanredna)
        {
            try
            {
                await DTOManager.DodajVanrednuSituaciju(vanredna);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpGet]
        [Route("PrikazSituacija")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazSituacija()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiVanredneSituacije());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpGet]
        [Route("PrikazSituacije/{vanrednaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazSituacije(int vanrednaId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiVanrednuSituaciju(vanrednaId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpDelete]
        [Route("VanrednaDelete/{vanrednaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        public async Task<IActionResult> VanrednaDelete(int vanrednaId)
        {
            try
            {
                await DTOManager.obrisiVanrednuSituaciju(vanrednaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut]
        [Route("VanrednaChange/{vanrednaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        public async Task<IActionResult> VanrednaChange(int vanrednaId, [FromBody] DTODodajVanrednuSituaciju vanredna)
        {
            try
            {
                await DTOManager.IzmeniVanrednuSituaciju(vanredna, vanrednaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }


        [HttpGet]
        [Route("PrikazSaradnji/{vanrednaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazSaradnji(int vanrednaId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSveSluzbeKojeSaradjujuSaVS(vanrednaId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpGet]
        [Route("PrikazIntervenisanja/{vanrednaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazIntervenisanja(int vanrednaId)
        {
            try
            {
                return new JsonResult(await DTOManager.VanrednaUcestvovanjaVratii(vanrednaId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
