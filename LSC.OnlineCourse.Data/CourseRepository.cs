using LSC.OnlineCourse.Core.Entities;
using LSC.OnlineCourse.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace LSC.OnlineCourse.Data
{
    public class CourseRepository(OnlineCourseDbContext _dbContext) : ICourseRepository
    {
        public Task<List<CourseDto>> GetAllCourseAsync(int? categoryId = null)
        {
            throw new NotImplementedException();
        }

        public Task<CourseDetailDto> GetCourseDetailAsync(int courseId)
        {
            var course = _dbContext.Courses.Include(c=>c.Category)
        }
    }
}