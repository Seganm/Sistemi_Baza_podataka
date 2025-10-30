using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerJedinica : ControllerBase
    {
        [HttpPost]
        [Route("SpecijalnaDodaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SpecijalnaDodaj([FromBody] DTOOsnovnaSpecijalnaInterventnaJedinica specijalna)
        {
            try
            {
                await DTOManager.DodajSpecijalnuIntervetnuJedinicu(specijalna);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("SpecijalneVrati")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SpecijalneVrati()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSpecijalneJedinice());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("SpecijalnaVratiPoId/{specijalnaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiSpecijalnuPoId(int specijalnaId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSpecijalnuJedinicu(specijalnaId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("specijalnaObrisi/{specijalnaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> specijalnaObrisi(int specijalnaId)
        {
            try
            {
                await DTOManager.ObrisiSpecijalnuInterventnuJedinicu(specijalnaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("specijalnaIzmeni/{specijalnaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> specijalnaIzmeni(int specijalnaId, [FromBody] DTOOsnovnaSpecijalnaInterventnaJedinica specijalna)
        {
            try
            {
                await DTOManager.izmeniSpecijalnuInterventnuJedinicu(specijalna, specijalnaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("OpstaDodaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> OpstaDodaj([FromBody] DTOOsnovnaOpstaInterventnaJedinica opsta)
        {
            try
            {
                await DTOManager.DodajOpstuIntervetnuJedinicu(opsta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("OpsteVrati")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> OpsteVrati()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiOpstejedinice());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("JediniceVrati")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> JediniceVrati()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSveJedinice());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("OpstaVratiPoId/{opstaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiSOpstuJedinicu(int opstaId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiOpstuJedinicu(opstaId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("opstaObrisi/{opstaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> opstaObrisi(int opstaId)
        {
            try
            {
                await DTOManager.ObrisiOpstuInterventnuJedinicu(opstaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("OpstaIzmeni/{opstaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> OpstaIzmeni(int opstaId, [FromBody] DTOOsnovnaOpstaInterventnaJedinica opsta)
        {
            try
            {
                await DTOManager.IzmeniOpstuInterventnuJedinicu(opsta, opstaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("JedinicaVozila/{jedinicaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> JedinicaVozila(int id)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiDodeljivanjaJedinic(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("JedinicaRadnici/{idJedinice}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> JedinicaRadnici(int id)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiOperativneRadnikeIzJedincie(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("JedinicaOprema/{idJedinice}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> JedinicaOprema(int id)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSvuOpremuJedinice(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("JedinicaUcestvovanja/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> JedinicaUcestvovanja(int id)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSvaUcestvovanjaJedinice(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
