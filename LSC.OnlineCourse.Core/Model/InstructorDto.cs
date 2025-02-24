namespace LSC.OnlineCourse.Core.Model
{
    public class InstructorDto
    {
        public int InstructorId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Bio { get; set; }

        public int UserId { get; set; }
    }
    
   
}
