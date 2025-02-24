using LSC.OnlineCourse.Core.Entities;

namespace LSC.OnlineCourse.Data
{
    public interface ICourseCategoryRepository
    {
        Task<CourseCategory>? GetByIdAsync(int id);
        Task<List<CourseCategory>> GetCourseCategoriesAsync();
    }
}
