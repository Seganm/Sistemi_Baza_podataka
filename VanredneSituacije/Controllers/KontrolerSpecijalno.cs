using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerSpecijalno : ControllerBase
    {
        [HttpPost]
        [Route("SpecijalnoAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SpecijalnoAdd([FromBody] DTODodajSpecijalno specijalno)
        {
            try
            {
                await DTOManager.DodajSpecijalnoVozilo(specijalno);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazSpecijalnih")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazSpecijalnih()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSpecijalnaVozila());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("SpecijalnoPrikaz/{registracija}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SpecijalnoPrikaz(string registracija)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSpecijalnoVozilo(registracija));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("SpecijalnoDelete/{registracija}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SpecijalnoDelete(string registracija)
        {
            try
            {
                await DTOManager.ObrisiSpecijalnoVozilo(registracija);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("SpecijalnoChange/{registracija}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SpecijalnoChange(string registracija, [FromBody] DTODodajSpecijalno specijalno)
        {
            try
            {
                await DTOManager.IzmeniSpecijalnaVozila(specijalno, registracija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
