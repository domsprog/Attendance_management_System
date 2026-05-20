using System.ComponentModel.DataAnnotations;

namespace AttendanceManagement.DTO
{
    public class TeacherDTO
    {
        public class CreateTeacherDTO
        {
            [Required]
            [StringLength(50, ErrorMessage = "Teacher First Name connot exceed 50 characters")]
            public string FirstName { get; set; } = string.Empty;// e.g., "Dr. Smith", "Prof. Johnson"
            [Required]
            [StringLength(50, ErrorMessage = "Teacher Last Name connot exceed 50 characters")]
            public string LastName { get; set; } = string.Empty;// e.g., "Smith", "Johnson"
            [Required]
            [EmailAddress(ErrorMessage = "Invalid email format.")]
            public string Email { get; set; } = string.Empty;// e.g., "
            [Required]
            public string CourseCodes { get; set; } = string.Empty;// e.g., "CS101, MATH201"
            [Required]
            [RegularExpression("^(Active|Inactive|On Leave)$", ErrorMessage = "Status must be either 'Active', 'Inactive', or 'On Leave'.")]
            public string Status { get; set; } = string.Empty;// e.g., "Active", "Inactive", "On Leave"
        }

        public class UpdateTeacherDTO
        {
            [Required]
            [StringLength(50, ErrorMessage = "Teacher First Name connot exceed 50 characters")]
            public string FirstName { get; set; } = string.Empty;// e.g., "Dr. Smith", "Prof. Johnson"
            [Required]
            [StringLength(50, ErrorMessage = "Teacher Last Name connot exceed 50 characters")]
            public string LastName { get; set; } = string.Empty;// e.g., "Smith", "Johnson"
            [Required]
            [EmailAddress(ErrorMessage = "Invalid email format.")]
            public string Email { get; set; } = string.Empty;// e.g., "
            [Required]
            public string CourseCodes { get; set; } = string.Empty;// e.g., "CS101, MATH201"
            [Required]
            [RegularExpression("^(Present|Absent|On Leave)$", ErrorMessage = "Status must be either 'Present', 'Absent', or 'On Leave'.")]
            public string Status { get; set; } = string.Empty;// e.g., "Present", "Absent", "On Leave"
        }

        public class ResponseTeacherDTO
        {
            public ResponseTeacherDTO(int teacherId, string firstName, string lastName, string email, string courseCodes, string status)
            {
                TeacherId = teacherId;
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                CourseCodes = courseCodes;
                Status = status;
            }
            public int TeacherId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string CourseCodes { get; set; }
            public string Status { get; set; }
        }
    }

}
