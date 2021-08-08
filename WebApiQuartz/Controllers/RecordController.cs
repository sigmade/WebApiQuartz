using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApiQuartz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly RecordSevice _recordSevice;
        public RecordController(RecordSevice recordSevice)
        {
            _recordSevice = recordSevice;
        }

        [HttpGet("check-db")]
        public async Task<IActionResult> GetRecords()
        {
            var records = await _recordSevice.GetRecords();

            return Ok(records);
        }

        [HttpGet("check-api")]
        public async Task<IActionResult> CheckWebApi()
        {
            return Ok("WebApi - work!!!");
        }

        [HttpGet("add")]
        public async Task<IActionResult> AddRecords()
        {
            await _recordSevice.AddRecord("Message from cotroller");

            return NoContent();
        }
    }
}
