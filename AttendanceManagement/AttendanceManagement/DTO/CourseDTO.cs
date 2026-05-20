using System.ComponentModel.DataAnnotations;

namespace AttendanceManagement.DTO
{
    public class CreateCourseDTO
    {
        [Required]
        [RegularExpression(@"^[A-Z]{3}\d{3}$", ErrorMessage = "Course code must be in the format ABC123.")]
        public string CourseCode { get; set; } = string.Empty; // e.g., "CS101", "MATH201"
        [Required]
        [StringLength(100, ErrorMessage = "Course name cannot exceed 100 characters.")]
        public string CourseName { get; set; } = string.Empty; // e.g., "Introduction to Computer Science"
        [Required]
        [StringLength(100, ErrorMessage = "Teacher name cannot exceed 100 characters.")]
        public string AssignedTeacher { get; set; } = string.Empty; // e.g., "Dr. Smith", "Prof. Johnson"
        [Required]
        [Range(1, 5, ErrorMessage = "Units must be between 1 and 5.")]
        public int Units { get; set; } // e.g., 3, 4
    }

    public class UpdateCourseDTO
    {
        [Required]
        [RegularExpression(@"^[A-Z]{3}\d{3}$", ErrorMessage = "Course code must be in the format ABC123.")]
        public string CourseCode { get; set; } = string.Empty; // e.g., "CS101", "MATH201"
        [Required]
        [StringLength(100, ErrorMessage = "Course name cannot exceed 100 characters.")]
        public string CourseName { get; set; } = string.Empty; // e.g., "Introduction to Computer Science"
        [Required]
        [StringLength(100, ErrorMessage = "Teacher name cannot exceed 100 characters.")]
        public string AssignedTeacher { get; set; } = string.Empty; // e.g., "Dr. Smith", "Prof. Johnson"
        [Required]
        [Range(1, 5, ErrorMessage = "Units must be between 1 and 5.")]
        public int Units { get; set; } // e.g., 3, 4
    }

    public class ResponseCourseDTO
    {
        public ResponseCourseDTO(string courseCode, string courseName, string assignedTeacher, int units)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            AssignedTeacher = assignedTeacher;
            Units = units;
        }
        public string CourseCode { get; set; } // e.g., "CS101", "MATH201"
        public string CourseName { get; set; } // e.g., "Introduction to Computer Science"
        public string AssignedTeacher { get; set; } // e.g., "Dr. Smith", "Prof. Johnson"
        public int Units { get; set; } // e.g., 3, 4
    }

}
