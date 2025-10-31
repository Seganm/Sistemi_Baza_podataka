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

        public async Task<IActionResult> IstorijaUlogaAdd([FromBody] DTOIstorijaDodajj istorija)
        {
            try
            {
                await DTOManager.IstorijaDodajj(istorija);
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
                return new JsonResult(await DTOManager.ZaposleniVratii());
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
                return new JsonResult(await DTOManager.IstorijaVratiPoJMBG(maticniBroj));
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
                await DTOManager.IstorijaObrisii(istorijaId);
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

        public async Task<IActionResult> IstorijaChange([FromBody] DTOIstorijaDodajj istorija, int istorijaId)
        {
            try
            {
                await DTOManager.IstorijaIzmenii(istorija, istorijaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
