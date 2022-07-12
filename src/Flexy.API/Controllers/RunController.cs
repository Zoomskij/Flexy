using Microsoft.AspNetCore.Mvc;
using Flexy.Services.Interfaces;

namespace Flexy.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RunController : Controller
    {
        private readonly IReceiverService _receiverService;
        public RunController(IReceiverService receiverService)
        {
            _receiverService = receiverService;
        }

        [HttpGet(Name = "Start")]
        public IActionResult Index()
        {
            
            return Ok();
        }
    }
}
