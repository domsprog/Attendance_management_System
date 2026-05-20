namespace AttendanceManagement.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; } = string.Empty;// e.g., "Dr. Smith", "Prof. Johnson"
        public string LastName { get; set; } = string.Empty;// e.g., "Smith", "Johnson"
        public string Email { get; set; } = string.Empty;// e.g., "
        public string CourseCodes { get; set; } = string.Empty;// e.g., "CS101, MATH201"
        public string Status { get; set; } = string.Empty;// e.g., "Present", "Absent", "On Leave"
    }
}
