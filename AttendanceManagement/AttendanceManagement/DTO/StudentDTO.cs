using System.ComponentModel.DataAnnotations;

namespace AttendanceManagement.DTO
{
    public class CreateStudentDTO
    {
        [Required]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Student ID must be exactly 8 digits.")]
        public string StudentID { get; set; } ="24094629";

        [Required]
        [StringLength(50, ErrorMessage = "Student First Name connot exceed 50 characters")]
        public string FirstName { get; set; } 

        [Required]
        [StringLength(50, ErrorMessage ="Student Last Name connot exceed 50 characters")]
        public string LastName { get; set; } 

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^(Present|Absent|Excused)$", ErrorMessage = "Status must be either 'Present', 'Absent', or 'Excused'.")]
        public string Status { get; set; }
    }

    public class UpdateStudentDTO
    {
        [Required]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Student ID must be exactly 8 digits.")]
        public string StudentID { get; set; } = "24094629";
        [Required]
        [StringLength(50, ErrorMessage = "Student First Name connot exceed 50 characters")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Student Last Name connot exceed 50 characters")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^(Present|Absent|Excused)$", ErrorMessage = "Status must be either 'Present', 'Absent', or 'Excused'.")]
        public string Status { get; set; }
    }

    public class ResponseStudentDTO
    {
        public ResponseStudentDTO(string studentID, string firstName, string lastName, string email, string status)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Status = status;
        }
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }
}
