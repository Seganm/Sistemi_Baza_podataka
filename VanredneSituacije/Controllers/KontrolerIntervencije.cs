using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;
namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerIntervencije : ControllerBase
    {
        [HttpPost]
        [Route("IntervencijaDodaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> IntervencijaDodaj([FromBody] DTOOsnovnaIntervencija intervencija)
        {
            try
            {
                await DTOManager.DodajIntervenciju(intervencija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PrikazIntervencija")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> PrikazIntervencija()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiIntervencije());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSvaIntervenise/{ucestvovanjeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> VratiSvaIntervenise(int ucestvovanjeId)
        {
            try
            {
                return new JsonResult(await DTOManager.IntervencijaUcestvovanjaVratii(ucestvovanjeId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("IntervencijaObrisi/{intervencijaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> IntervencijaObrisi(int intervencijaId)
        {
            try
            {
                await DTOManager.ObrisiIntervenciju(intervencijaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }



        [HttpPut]
        [Route("IntervencijaIzmeni/{intervencijaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> IntervencijaIzmeni([FromBody] DTOOsnovnaIntervencija intervencija, int intervencijaId)
        {
            try
            {
                await DTOManager.IzmeniIntervenciju(intervencija, intervencijaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
