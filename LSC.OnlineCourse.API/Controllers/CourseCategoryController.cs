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
        public async Task<IActionResult> Get(int id)
        {
            var category = await categoryService.GetByIdAsync(id);
            if (category == null) 
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await categoryService.GetAllAsync();
            if (categories is null)
            {
                return NotFound();
            }

            return Ok(categories);
        }
    }
}
