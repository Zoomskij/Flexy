using Microsoft.AspNetCore.Mvc;
using Flexy.Entities;
using Flexy.Services.Interfaces;

namespace Flexy.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IReceiverService _reseiverService;
        public CoursesController(ICourseService courseService, IReceiverService reseiverService)
        {
            _courseService = courseService;
            _reseiverService = reseiverService;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = _courseService.GetCourses();
            return Ok(courses);
        }

        [HttpGet]
        [Route("/lessons/{courseGuid}")]
        public IActionResult GetLessonsByCourseGuid(Guid courseGuid)
        {
            var lessons = _courseService.GetLessonEntitiesByCourseGuid(courseGuid);
            return Ok(lessons);
        }

        [HttpGet]
        [Route("/tasks/{lessonGuid}")]
        public IActionResult GetTasksByLessonGuid(Guid lessonGuid)
        {
            var lessons = _courseService.GetTasksByLessonGuid(lessonGuid);
            return Ok(lessons);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddCourse([FromBody] CourseEntity course)
        {
            await _courseService.AddAsync(course);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateAchievment([FromBody] CourseEntity course)
        {
            await _courseService.UpdateAsync(course);
            return Ok();
        }

        [HttpDelete]
        [Route("{guid}")]
        public async Task<IActionResult> DeleteAchievment(Guid guid)
        {
            await _courseService.DeleteAsync(guid);
            return Ok();
        }
    }

    public class ChatEntityDto 
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
    }
}
