using LSC.OnlineCourse.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.OnlineCourse.Core.Model
{
    public class CourseDto:DtoBase
    {

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public string CourseType { get; set; } = null!;

        public int? SeatsAvailable { get; set; }

        public decimal Duration { get; set; }

        public int CategoryId { get; set; }

        public int InstructorId { get; set; }
        public int InstructorUserId { get; set; }
        public string? Thumbnail { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public CourseCategoryDto? Category { get; set; } = null!;
        public UserRatingDto? UserRating { get; set; } = null!;

    }
}
