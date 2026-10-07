using CardioSense.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CardioSense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcgController : ControllerBase
    {
        [HttpPost("upload")]
        public IActionResult UploadEcg([FromBody] EcgUploadDto dto)
        {
            return Ok(new { recordId = 1, aiResult = "Normal Sinus Rhythm", status = "Pending Doctor Review" });
        }
    }
}