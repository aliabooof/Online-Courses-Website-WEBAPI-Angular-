using LSC.OnlineCourse.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LSC.OnlineCourse.Data
{
    public class CourseCategoryRepository(OnlineCourseDbContext _dbContext) : ICourseCategoryRepository
    {
        public Task<CourseCategory>? GetByIdAsync(int id)
        {
            var data =  _dbContext.CourseCategories.FindAsync(id).AsTask();
            return data!;
        }
     

        public  Task<List<CourseCategory>> GetCourseCategoriesAsync()
        {
            var data =  _dbContext.CourseCategories.ToListAsync();
            return data;
        }
    }
}