using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerLicnaZastita : ControllerBase
    {
        [HttpPost]
        [Route("LicnaDodaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> LicnaDodaj([FromBody] DTODodajLicnuZastitu zastita)
        {
            try
            {
                await DTOManager.DodajLicnuZastitu(zastita);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
            [Route("LicnaVrati")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]

            public async Task<IActionResult> LicnaZastitaVrati()
            {
                try
                {
                    return new JsonResult(await DTOManager.VratiOpremuLicneZastite());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpGet]
            [Route("VratiLicnuPoBroju/{Serijski_Broj}")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]

            public async Task<IActionResult> VratiLicnuPoBroju(string broj)
            {
                try
                {
                    return new JsonResult(await DTOManager.VratiLicnuZastitu(broj));

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }

            }

        [HttpDelete]
        [Route("LicnaObrisi/{broj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> LicnaObrisi(string broj)
        {
            try
            {
                await DTOManager.ObrisiLicnuZastitu(broj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
            [Route("LicnaIzmeni/{broj}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]

            public async Task<IActionResult> LicnaIzmeni(string broj, [FromBody] DTODodajLicnuZastitu licna)
            {
                try
                {
                    await DTOManager.IzmeniLicnuZastitu(licna, broj);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
            
        }
}
