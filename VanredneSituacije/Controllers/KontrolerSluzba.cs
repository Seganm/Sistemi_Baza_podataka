using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerSluzba : ControllerBase
    {
        [HttpPost]
        [Route("SluzbaAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SluzbaAdd([FromBody] DTODodajSluzbu sluzba)
        {
            try
            {
                await DTOManager.DodajSluzbu(sluzba);
                return Ok(); ;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpGet]
        [Route("SveSluzbe")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SveSluzbe()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSluzbe());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("SluzbaPrikaz/{sluzbaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SluzbaPrikaz(int sluzbaId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSluzbu(sluzbaId));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("SluzbaDelete/{sluzbaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SluzbaDelete(int sluzbaId)
        {
            try
            {
                await DTOManager.ObrisiSluzbu(sluzbaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("SluzbaChange/{sluzbaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> SluzbaChange([FromBody] DTODodajSluzbu sluzba, int sluzbaId)
        {
            try
            {
                await DTOManager.IzmeniSluzbu(sluzba, sluzbaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("PredstavnikAdd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DodajPredstavnika([FromBody] DTOPredstavnikSluzbe predstavnik)
        {
            try
            {
                await DTOManager.DodajPredstavnika(predstavnik);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PredstavnikPrikaz")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PredstavnikPrikaz()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiPredstavnike());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PrikazPredstavnika/{sluzbaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PrikazPredstavnika(int sluzbaId)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiPredstacnikaJedinice(sluzbaId));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("PredstavnikDelete/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ObrisiPredstavnika(string maticniBroj)
        {
            try
            {
                await DTOManager.ObrisiPredstavnika(maticniBroj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut]
        [Route("PredstavnikChange/{maticniBroj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> PredstavnikChange([FromBody] DTOPredstavnikSluzbe predstavnik, string maticniBroj)
        {
            try
            {
                await DTOManager.IzmeniPredstavnika(predstavnik, maticniBroj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
