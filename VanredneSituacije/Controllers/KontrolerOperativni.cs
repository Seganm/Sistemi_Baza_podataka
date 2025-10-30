using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerOperativni : ControllerBase
    {

        [HttpPost]
        [Route("OperativniAdd")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> OperativniAdd([FromBody] DTODodajOperativnogRadnika operativni)
        {
            try
            {
                await DTOManager.DodajOperativnogRadnik(operativni);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiOperativne")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiOperativne()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiOperativneRadnike());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("VratiOperativnePoMaticnom/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> VratiOperativnePoMaticnom(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiOperativnogRadnika(maticniBroj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("OperativniDelete/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> OperativniDelete(string maticniBroj)
        {
            try
            {
                await DTOManager.ObrisiOperativnogRadnika(maticniBroj);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut]
        [Route("OperativniIzmeni/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> OperativniIzmeni([FromBody] DTODodajOperativnogRadnika operativni, string maticniBroj)
        {
            try
            {
                await DTOManager.IzmeniOperativnog(operativni, maticniBroj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("SertifikatDodaj")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> SertifikatDodaj([FromBody] DTOSertifikat sertifikat)
        {
            try
            {
                await DTOManager.DodajSertifikat(sertifikat);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("VratiSertifikati")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiSertifikati()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSertifikate());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        [HttpGet]
        [Route("VratiSertifikate/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiSertifikate(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSertifikateZaposlenog(maticniBroj));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("SertifikatDelete")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> SertifikatDelete([FromBody] DTODodajIdSertifikata sertifikat)
        {
            try
            {
                await DTOManager.ObrisiSertifikat(sertifikat);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
        }



        [HttpPut]
        [Route("SertifikatChange")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> SertifikatChange([FromBody] DTOSertifikat sertifikat)
        {
            try
            {
                await DTOManager.IzmeniSertifikat(sertifikat);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
