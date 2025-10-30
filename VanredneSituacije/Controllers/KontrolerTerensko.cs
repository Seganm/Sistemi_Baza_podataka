using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerTerensko : ControllerBase
    {
        [HttpPost]
        [Route("KamionAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> KamionAdd([FromBody] DTODodajKamion kamion)
        {
            try
            {
                await DTOManager.DodajKamion(kamion);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazKamiona")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazKamiona()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiKamione());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikaziKamion/{registracija}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikaziKamion(string registracija)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiKamion(registracija));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("KamionDelete/{registracija}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> KamionDelete(string registracija)
        {
            try
            {
                await DTOManager.ObrisiKamion(registracija);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("KamionChange/{registracija}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> KamionChange(string registracija, [FromBody] DTODodajKamion kamion)
        {
            try
            {
                await DTOManager.IzmeniKamion(kamion, registracija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DzipAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DzipAdd([FromBody] DTODodajDzip dzip)
        {
            try
            {
                await DTOManager.DodajDzip(dzip);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazDzipova")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazDzipova()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiDzipove());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikaziDzip/{registracija}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikaziDzip(string registracija)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiDzip(registracija));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("DzipDelete/{registracija}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> DzipDelete(string registracija)
        {
            try
            {
                await DTOManager.ObrisiDzip(registracija);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut]
        [Route("DzipChange/{registracija}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> DzipChange(string registracija, [FromBody] DTODodajDzip dzip)
        {
            try
            {
                await DTOManager.IzmeniDzip(dzip, registracija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
 
    }
}
