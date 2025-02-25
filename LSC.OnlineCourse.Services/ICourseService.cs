using LSC.OnlineCourse.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.OnlineCourse.Services
{
    public interface ICourseService
    {
        Task<CourseDetailDto> GetCourseDetailsAsync(int courseId);
        Task<List<CourseDto>> GetAllAsync( int? categoryId= null);
    }

}
