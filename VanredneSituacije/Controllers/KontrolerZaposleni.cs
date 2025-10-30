using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerZaposleni : ControllerBase
    {
        [HttpPost]
        [Route("IstorijaAdd")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> IstorijaUlogaAdd([FromBody] DTODodajIstorijuUloga istorija)
        {
            try
            {
                await DTOManager.DodajIstorijuUloga(istorija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazZaposlenih")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazZaposlenih()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSveZaposlene());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PrikazIstorijeUloga/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> PrikazIstorijeUloga(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiIstorijuUZaposlenog(maticniBroj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IstorijaDelete/{istorijaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> IstorijaDelete(int istorijaId)
        {
            try
            {
                await DTOManager.ObrisiIstorijuUloga(istorijaId);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IstorijaChange/{istorijaId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> IstorijaChange([FromBody] DTODodajIstorijuUloga istorija, int istorijaId)
        {
            try
            {
                await DTOManager.IzmeniIstorijuUloga(istorija, istorijaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
