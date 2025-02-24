using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.OnlineCourse.Core.Model
{
    public class CourseCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = default!;
        public string Description { get; set;} = default!;

    }
}
