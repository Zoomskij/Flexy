using Microsoft.AspNetCore.Mvc;
using Flexy.Entities;
using Flexy.Services.Interfaces;
using Flexy.API.Authorization;

namespace Flexy.API.Controllers
{
    [Authorize]
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
            var currentUser = (User)HttpContext.Items["User"];
            if (currentUser == null)
                return BadRequest();

            //Move to repository filter
            var goals = _goalService.Get();
            return Ok(goals);
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
            var goals = _goalService.DeleteAsync(guid);
            return Ok();
        }

    }
}

public class GoalDto
{
    public string Text { get; set; }
}
