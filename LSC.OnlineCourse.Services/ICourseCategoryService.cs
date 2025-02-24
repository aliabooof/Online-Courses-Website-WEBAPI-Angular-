using LSC.OnlineCourse.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.OnlineCourse.Services
{
    public interface ICourseCategoryService
    {
        Task<CourseCategoryDto> GetByIdAsync(int id);
        Task<List<CourseCategoryDto>> GetAllAsync();
    }
}
