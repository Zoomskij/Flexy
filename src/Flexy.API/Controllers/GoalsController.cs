using Microsoft.AspNetCore.Mvc;
using Flexy.Entities;
using Flexy.Services.Interfaces;

namespace Flexy.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoalsController : Controller
    {
        private readonly IGoalService _goalService;
        public GoalsController(IGoalService goalService)
        {
            _goalService = goalService; 
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetGoals()
        {
            var achievments = _goalService.Get();
            return Ok(achievments);
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddGoal([FromBody] GoalDto goalDto)
        {
            var currentUser = (User)HttpContext.Items["User"];
            if (currentUser == null)
                return BadRequest();
            Goal goal = new Goal
            {
                Text = goalDto.Text,
                Owner = currentUser
            };
            _goalService.AddAsync(goal);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult UpdateGoal([FromBody] Goal goal)
        {
            _goalService.UpdateAsync(goal);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult DeleteGoal(Guid guid)
        {
            var achievments = _goalService.DeleteAsync(guid);
            return Ok();
        }

    }
}

public class GoalDto
{
    public string Text { get; set; }
}
