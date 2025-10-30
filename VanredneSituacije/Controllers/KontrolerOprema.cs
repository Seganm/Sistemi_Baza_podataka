using Microsoft.AspNetCore.Mvc;
using VanredneSituacije;

namespace VanredneSituacijeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrolerOprema : ControllerBase
    {
        [HttpGet]
        [Route("OpremaVrati")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> OpremaVrati()
        {
            try
            {
                return new JsonResult(await DTOManager.VratiSvuOpremu());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
