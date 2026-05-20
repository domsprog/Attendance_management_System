
namespace AttendanceManagement.Models
{
    public class Course
    {
        public string CourseCode { get; set; } = string.Empty;// e.g., "CS101", "MATH201"
        public string CourseName { get; set; } = string.Empty;// e.g., "Introduction to Computer Science", "Calculus II"
        public int TeacherId { get; set; } = 0; //10,283,1045
        public string TeacherName { get; set ; } = string.Empty;// e.g., "Dr. Smith", "Prof. Johnson"
        public int Units { get; set; } = 0; // e.g., 3, 4
    }
}
