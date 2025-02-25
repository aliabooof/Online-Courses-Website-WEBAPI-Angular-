using LSC.OnlineCourse.Core.Model;
using LSC.OnlineCourse.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LSC.OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController(ICourseCategoryService categoryService) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseCategoryDto>> Get( int id)
        {
            var category = await categoryService.GetByIdAsync(id);
            if (category == null) 
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpGet]
        public async Task<ActionResult<List<CourseCategoryDto>>> GetAll()
        {
            var courseDetail = await categoryService.GetAllAsync();
            if (courseDetail is null)
            {
                return NotFound();
            }

            return Ok(courseDetail);
        }
    }
}
