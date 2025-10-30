using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerKoordinator : ControllerBase
    {
        [HttpPost]
        [Route("KoordinatorAdd")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> KoordinatorAdd([FromBody] DTOKoordinator koordinator)
        {
            try
            {
                await DTOManager.DodajKordinatora(koordinator);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiKoordinatore")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiKoordinatore()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiKordinatora());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("VratiKoordinatora/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> VratiKoordinatora(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiKordinator(maticniBroj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("KoordinatorDelete/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> KoordinatorDelete(string maticniBroj)
        {
            try
            {
                await DTOManager.ObrisiKordinatora(maticniBroj);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("KoordinatorIzmeni/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> KoordinatorIzmeni([FromBody] DTOKoordinator koordinator, string maticniBroj)
        {
            try
            {
                await DTOManager.IzmeniKordinatora(koordinator, maticniBroj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("SpecijalizacijaAdd")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> SpecijalizacijaAdd([FromBody] DTODodajSpecijalizaciju specijalizacija)
        {
            try
            {
                await DTOManager.DodajSpecijalizaciju(specijalizacija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("SpecijalizacijeVrati")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SpecijalizacijeVrati()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSpecijalizacije());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSpecijalizacija/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiSpecijalizacija(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSpecijalizacijeKoordinatora(maticniBroj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("SpecijalizacijaDelete/{specijalizacijaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> SpecijalizacijaDelete(int specijalizacijaId)
        {
            try
            {
                await DTOManager.ObrisiSpecijalizaciju(specijalizacijaId);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }

        }


        [HttpPut]
        [Route("SpecijalizacijaChange/{specijalizacijaId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> SpecijalizacijaChange([FromBody] DTODodajSpecijalizaciju specijalizacija, int specijalizacijaId)
        {
            try
            {
                await DTOManager.IzmeniSpecijalizaciju(specijalizacija, specijalizacijaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    
    }
}
