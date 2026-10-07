using CardioSense.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CardioSense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AiController : ControllerBase
    {
        [HttpPost("analyze")]
        public IActionResult AnalyzeEcg([FromBody] EcgUploadDto dto)
        {
            return Ok(new { recordId = 1, classification = "Normal", confidenceScore = 0.95 });
        }
    }
}