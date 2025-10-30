using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerTehnicka : ControllerBase
    {
        [HttpPost]
        [Route("TehnickaDodaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> TehnickaAdd([FromBody] DTODodajTehnicku tehnicka)
        {
            try
            {
                await DTOManager.DodajTehnickuOpremu(tehnicka);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazTehnicke")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazTehnicke()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiTehnickuZastitu());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikaziTehnicku/{broj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikaziTehnicku(string broj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiTehnickuOpremu(broj));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpDelete]
        [Route("TehnickaDelete/{broj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> TehnickaDelete(string broj)
        {
            try
            {
                await DTOManager.ObrisiTehnickuOpremu(broj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("TehnickaChange/{broj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> TehnickaChange(string broj, [FromBody] DTODodajTehnicku tehnicka)
        {
            try
            {
                await DTOManager.IzmeniTehnickuOpremu(tehnicka, broj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
