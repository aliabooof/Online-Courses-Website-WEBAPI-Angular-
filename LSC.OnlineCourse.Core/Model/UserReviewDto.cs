namespace LSC.OnlineCourse.Core.Model
{
    public class UserReviewDto:DtoBase
    {
        public int ReviewId { get; set; }
        
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;

        public int Rating { get; set; }

        public string? Comments { get; set; }

        public DateTime ReviewDate { get; set; }
    }
   
}
