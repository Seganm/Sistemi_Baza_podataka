using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerVozilo : ControllerBase
    {
        [HttpPost]
        [Route("ServisAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ServisAdd([FromBody] DTODodajEvidencijuServis servis)
        {
            try
            {
                await DTOManager.DodajServis(servis);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazServisa")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazServisa()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiServise());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ServisDelete/{servisId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ObrisiServis(int servisId)
        {
            try
            {
                await DTOManager.ObrisiServis(servisId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("ServisChange/{servisId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ServisChange([FromBody] DTODodajEvidencijuServis servis, int servisId)
        {
            try
            {
                await DTOManager.IzmeniServis(servis, servisId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        [HttpGet]
        [Route("PrikazVozila")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazVozila()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSvaVozila());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazDodela/{registracija}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazDodela(string registracija)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiDodeljivanjaVozila(registracija));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("UcestvovanjaPrikaz/{intervencijaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> UcestvovanjaPrikaz(int intervencijaId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiUcestvovanjaVozilaU(intervencijaId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PrikazUcestvovanjaVozila/{registracija}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazUcestvovanjaVozila(string registracija)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiUcestvovanjeVozilaUKojimajeUcestvovalo(registracija));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VoziloServisi/{registracija}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VoziloServisi(string registracija)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiServiseVozila(registracija));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
  
    }
}
