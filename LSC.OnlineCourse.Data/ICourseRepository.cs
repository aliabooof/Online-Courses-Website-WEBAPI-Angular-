using LSC.OnlineCourse.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.OnlineCourse.Data
{
    public interface ICourseRepository
    {
        Task<List<CourseDto>> GetAllCourseAsync(int? categoryId = null);
        Task<CourseDetailDto> GetCourseDetailAsync(int courseId);
    }
}
