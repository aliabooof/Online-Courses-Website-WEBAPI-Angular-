namespace LSC.OnlineCourse.Core.Model
{
    public class SessionDetailDto:DtoBase
    {
        public int SessionId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public string? VideoUrl { get; set; }

        public int VideoOrder { get; set; }

    }
}
