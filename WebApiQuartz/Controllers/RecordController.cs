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

        [HttpGet("check")]
        public async Task<IActionResult> GetRecords()
        {
            var records = await _recordSevice.GetRecords();

            return Ok(records);
        }

        [HttpGet("add")]
        public async Task<IActionResult> AddRecords()
        {
            await _recordSevice.AddRecord("Message from cotroller");

            return NoContent();
        }
    }
}
