using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;
namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerAnaliticar : ControllerBase
    {
        [HttpPost]
        [Route("AnaliticarDodaj")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> AnaliticarDodaj([FromBody] DTOAnaliticar analiticar)
        {
            try
            {
                await DTOManager.AnaliticarDodajj(analiticar);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSveAnaliticare")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiSveAnaliticare()
        {
            try
            {
                return new JsonResult(await DTOManager.AnaliticariVratii());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("AnaliticarVratiiPoJMBG/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> AnaliticarVratiiPoJMBG(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.AnaliticarVratii(maticniBroj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("AnaliticarObrisi/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> AnaliticarObrisi(string maticniBroj)
        {
            try
            {
                await DTOManager.AnaliticarObrisii(maticniBroj);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("AnaliticarIzmeni/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> AnaliticarIzmeni([FromBody] DTOAnaliticar analiticar, string maticniBroj)
        {
            try
            {
                await DTOManager.AnaliticarIzmenii(analiticar, maticniBroj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("EkspertizaDodaj")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> EkspertizaDodaj([FromBody] DTOEkspertizaIzmenii ekspertiza)
        {
            try
            {
                await DTOManager.EkspertizaDodajj(ekspertiza);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSveEkspertize")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiSveEkspertize()
        {
            try
            {
                return new JsonResult(await DTOManager.EkspertizeVratii());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("EkspertizeVratii/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> EkspertizeVratii(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.EkspertizeVratiPoJMBG(maticniBroj));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("EkspertizaObrisi/{ekspertizaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> EkspertizaObrisi(int ekspertizaId)
        {
            try
            {
                await DTOManager.EkspertizaObrisii(ekspertizaId);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }


        }


        [HttpPut]
        [Route("EkspertizaIzmeni/{ekspertizaId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> EkspertizaIzmeni(int ekspertizaId, [FromBody] DTOEkspertizaIzmenii ekspertiza)
        {
            try
            {
                await DTOManager.EkspertizaIzmenii(ekspertiza, ekspertizaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("SoftverDodaj")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> SoftverDodaj([FromBody] DTOSoftveriDodajj softver)
        {
            try
            {
                await DTOManager.SoftveriDodajj(softver);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("SoftverVratiPoIDi")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SoftverVratiPoIDi()
        {
            try
            {
                return new JsonResult(await DTOManager.SoftveriVratii());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("SoftverVratiPoIDPoJMBG/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SoftverVratiPoIDPoJMBG(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.SoftverVratiPoJMBG(maticniBroj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("SoftverObrisi/{softverId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> SoftverObrisi(int softverId)
        {
            try
            {
                await DTOManager.SoftveriObrisii(softverId);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }

        }


        [HttpPut]
        [Route("SoftverIzmeni/{softverId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> SoftverIzmeni(int softverId, [FromBody] DTOSoftveriDodajj softver)
        {
            try
            {
                await DTOManager.SoftverIzmenii(softver, softverId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }   

    }
}
