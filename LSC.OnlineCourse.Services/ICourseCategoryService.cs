
using LSC.OnlineCourse.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.OnlineCourse.Services
{
    public interface ICourseCategoryService
    {
        Task<CourseCategoryModel> GetByIdAsync(int id);
        Task<List<CourseCategoryModel>> GetAllAsync();
    }
}
