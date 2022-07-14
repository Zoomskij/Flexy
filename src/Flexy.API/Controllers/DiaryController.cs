using Microsoft.AspNetCore.Mvc;
using Flexy.Entities;
using Flexy.Services.Interfaces;
using Flexy.API.Authorization;

namespace Flexy.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DiaryController : Controller
    {
        private readonly IDiaryService _diaryService;
        private readonly User _currentUser;
        public DiaryController(IDiaryService diaryService)
        {
            _diaryService = diaryService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetGoals()
        {
            var currentUser = (User)HttpContext.Items["User"];
            if (currentUser == null)
                return BadRequest();

            var diaryComments = _diaryService.Get();
            //Move to repository filter
            return Ok(diaryComments.Where(x => x.User != null && x.User.Id == currentUser.Id));
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddGoal([FromBody] DiaryCommentDto diaryCommentDto)
        {
            var currentUser = (User)HttpContext.Items["User"];
            if (currentUser == null)
                return BadRequest();
            DiaryComment diaryComment = new DiaryComment
            {
                Text = diaryCommentDto.Text,
                User = currentUser
            };
            _diaryService.AddAsync(diaryComment);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult UpdateGoal([FromBody] DiaryComment diaryComment)
        {
            _diaryService.UpdateAsync(diaryComment);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult DeleteGoal(Guid guid)
        {
            var achievments = _diaryService.DeleteAsync(guid);
            return Ok();
        }

    }
}

public class DiaryCommentDto
{
    public string Text { get; set; }
}
