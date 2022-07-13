using Microsoft.AspNetCore.Mvc;
using Flexy.Entities;
using Flexy.Services.Interfaces;
using Flexy.Models.Meettings;
using Flexy.API.Authorization;

namespace Flexy.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MeetingsController : Controller
    {
        private readonly IMeetingService _meetingService;
        public MeetingsController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var meetings = _meetingService.Get(); ;
            return Ok(meetings);
        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddCourse([FromBody] AddMeetingRequest meeting)
        {
            var currentUser = (User)HttpContext.Items["User"];
            if (currentUser == null)
                return BadRequest();

            meeting.Owner = currentUser;
            await _meetingService.AddAsync(meeting);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateAchievment([FromBody] Meeting meeting)
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            await _meetingService.UpdateAsync(meeting);
            return Ok();
        }

        [HttpDelete]
        [Route("{guid}")]
        public async Task<IActionResult> DeleteAchievment(Guid guid)
        {
            await _meetingService.DeleteAsync(guid);
            return Ok();
        }
    }
}
