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
                await DTOManager.DodajAnalitcar(analiticar);
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
                return new JsonResult(await DTOManager.VratiAnaliticare());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiAnaliticaraPoJMBG/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> VratiAnaliticaraPoJMBG(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiAnaliticara(maticniBroj));
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
                await DTOManager.ObrisiAnaliticara(maticniBroj);
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
                await DTOManager.IzmeniAnaliticar(analiticar, maticniBroj);
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

        public async Task<IActionResult> EkspertizaDodaj([FromBody] DTOIzmeniEkspertizu ekspertiza)
        {
            try
            {
                await DTOManager.DodajEkspertizu(ekspertiza);
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
                return new JsonResult(await DTOManager.VratiEkspertize());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("VratiEkspertize/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiEkspertize(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiEkspertizeAnaliticara(maticniBroj));
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
                await DTOManager.ObrisiEkspertizu(ekspertizaId);
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

        public async Task<IActionResult> EkspertizaIzmeni(int ekspertizaId, [FromBody] DTOIzmeniEkspertizu ekspertiza)
        {
            try
            {
                await DTOManager.IzmeniEkspertizu(ekspertiza, ekspertizaId);
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

        public async Task<IActionResult> SoftverDodaj([FromBody] DTODodajSoftver softver)
        {
            try
            {
                await DTOManager.DodajSoftver(softver);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("VratiSoftveri")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiSoftveri()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSoftvere());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("VratiSoftverPoJMBG/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiSoftverPoJMBG(string maticniBroj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSoftvereAnaliticara(maticniBroj));
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
                await DTOManager.ObrisiSoftver(softverId);
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

        public async Task<IActionResult> SoftverIzmeni(int softverId, [FromBody] DTODodajSoftver softver)
        {
            try
            {
                await DTOManager.IzmeniSoftver(softver, softverId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }   

    }
}
