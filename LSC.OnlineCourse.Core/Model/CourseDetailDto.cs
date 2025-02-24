namespace LSC.OnlineCourse.Core.Model
{
    public class CourseDetailDto : CourseDto 
    {
        public List<UserReviewDto>? Reviews { get; set; } = new List<UserReviewDto>();


        public required List<SessionDetailDto> SessionDetails { get; set; }
    }
}
