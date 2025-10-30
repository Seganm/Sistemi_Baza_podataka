using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerSanitetsko : ControllerBase
    {
        [HttpPost]
        [Route("SanitetskoDodaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SanitetskoDodaj([FromBody] DTODodajSanitetsko sanitetsko)
        {
            try
            {
                await DTOManager.DodajSanitetskaVozilo(sanitetsko);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazSanitetska")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazSanitetska()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSanitetskaVozila());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazSanitetsko/{registracija}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazSanitetsko(string registracija)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSanitetkoVozilo(registracija));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("SanitetskoObrisi/{registracija}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SanitetskoObrisi(string registracija)
        {
            try
            {
                await DTOManager.ObrisiSanitetskoVozilo(registracija);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("SanitetskoIzmeni/{registracija}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SanitetskoIzmeni(string registracija, [FromBody] DTOIzmeniSanitetsko sanitetsko)
        {
            try
            {
                await DTOManager.IzmeniSanitetskoVozilo(sanitetsko, registracija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
