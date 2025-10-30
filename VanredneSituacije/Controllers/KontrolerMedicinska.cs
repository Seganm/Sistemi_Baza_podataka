using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;
using VanredneSituacije.DTO;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerMedicinska : ControllerBase
    {
        [HttpPost]
        [Route("MedicinskaDodaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> MedicinskaDodaj([FromBody] DTODodajMedicinsku medicinska)
        {
            try
            {
                await DTOManager.DodajMedicinskuOpremu(medicinska);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("MedicinskaVrati")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> MedicinskaVrati()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiMedicinskuZastitu());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiMedicinskuPoBroju/{broj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> VratiMedicinskuPoBroju(string broj)
        {
            try
            {
                return new JsonResult(await DTOManager.VratiMedicinskuOpremu(broj));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpDelete]
        [Route("MedicinskaObrisi/{broj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ObrisiMedicinskuOpremu(string broj)
        {
            try
            {
                await DTOManager.ObrisiMedicinskuOpremu(broj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("MedicinskaIzmeni/{broj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> MedicinskaIzmeni(string broj, [FromBody] DTODodajMedicinsku medicinska)
        {
            try
            {
                await DTOManager.IzmeniMedicinskuOpremu(broj, medicinska);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
