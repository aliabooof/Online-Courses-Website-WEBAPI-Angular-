using LSC.OnlineCourse.Core.Model;
using LSC.OnlineCourse.Data;

namespace LSC.OnlineCourse.Services
{
    public class CourseService(ICourseRepository courseRepository) : ICourseService
    {
        public async Task<List<CourseDto>> GetAllAsync(int? categoryId = null)
        {
            return await courseRepository.GetAllCourseAsync(categoryId);
        }

        public Task<CourseDetailDto> GetCourseDetailsAsync(int courseId)
        {
            return courseRepository.GetCourseDetailAsync(courseId);
        }

       
    }

}
