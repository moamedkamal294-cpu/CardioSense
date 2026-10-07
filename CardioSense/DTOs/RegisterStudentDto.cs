namespace CardioSense.DTOs
{
    public class RegisterStudentDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UniversityEmail { get; set; } = string.Empty;
        public int StudyYears { get; set; }
    }
}