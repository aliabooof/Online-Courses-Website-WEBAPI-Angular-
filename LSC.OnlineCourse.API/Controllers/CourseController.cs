using LSC.OnlineCourse.Core.Model;
using LSC.OnlineCourse.Services;
using Microsoft.AspNetCore.Mvc;

namespace LSC.OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController(ICourseService courseService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<CourseDto>>> GetAll()
        {
            var categories = await courseService.GetAllAsync();
            if (categories is null)
            {
                return NotFound();
            }

            return Ok(categories);
        }

        [HttpGet("Category/{categoryId}")]
        public async Task<ActionResult<List<CourseDto>>> Get([FromRoute]int categoryId)
        {
            var courses = await courseService.GetAllAsync(categoryId);
            if (courses == null) 
            {
                return NotFound();
            }

            return Ok(courses);
        }

        [HttpGet("Detail/{courseId}")]
        public async Task<ActionResult<CourseDto>> GetCourseDetail(int courseId)
        {
            var course = await courseService.GetCourseDetailsAsync(courseId);
            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }


    }
}
