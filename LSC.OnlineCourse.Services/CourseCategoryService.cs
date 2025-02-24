using LSC.OnlineCourse.Core.Model;
using LSC.OnlineCourse.Data;

namespace LSC.OnlineCourse.Services
{
    public class CourseCategoryService(ICourseCategoryRepository categoryRepository) : ICourseCategoryService
    {
        public async Task<List<CourseCategoryDto>> GetAllAsync()
        { 
            var data = await categoryRepository.GetCourseCategoriesAsync();
            var dataDto = data.Select(s => new CourseCategoryDto()
            {
                CategoryId = s.CategoryId,
                CategoryName = s.CategoryName,
                Description = s.Description!
            }).ToList();
            return dataDto;
        }

        public async Task<CourseCategoryDto> GetByIdAsync(int id)
        {
            var data = await categoryRepository.GetByIdAsync(id);
            return data == null? null! : new CourseCategoryDto
            {
                CategoryId = data.CategoryId,
                CategoryName = data.CategoryName,
                Description = data.Description!
            };
        }
    }
}
