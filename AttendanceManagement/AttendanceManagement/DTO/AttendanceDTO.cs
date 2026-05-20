using System.ComponentModel.DataAnnotations;

namespace AttendanceManagement.DTO
{
    public class CrateAttendanceDTO
    {
        [Required]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Student ID must be exactly 8 digits.")]
        public string StudentId { get; set; } = "24094629";

        [Required]
        [RegularExpression(@"^[A-Z]{3}\d{3}$", ErrorMessage = "Course code must be in the format ABC123.")]
        public string CourseCode { get; set; } = string.Empty; // e.g., "CS101", "MATH201"

        [Required]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Teacher ID must be exactly 4 digits.")]
        public string TeacherId { get; set; } = "1045"; //1045,4231,

        [Required]
        [RegularExpression("^(Present|Absent|Late|Excused)$", ErrorMessage = "Status: Present, Absent, Late, or Excused.")]
        public string Status { get; set; } = string.Empty; // e.g., "Present", "Absent", "Late"

        [StringLength(2000)]
        public string Remarks { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }
    }

    public class UpdateAttendanceDTO
    {
        [Required]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Student ID must be exactly 8 digits.")]
        public string StudentId { get; set; } = "24094629";

        [Required]
        [RegularExpression(@"^[A-Z]{3}\d{3}$", ErrorMessage = "Course code must be in the format ABC123.")]
        public string CourseCode { get; set; }

        [Required]
        [RegularExpression(@"^\d{7}$", ErrorMessage = "Teacher ID must be exactly 7 digits.")]
        public string TeacherId { get; set; } = 0; //10,283,1045

        [Required]
        [RegularExpression("^(Present|Absent|Late|Excused)$", ErrorMessage = "Status: Present, Absent, Late, or Excused.")]
        public string Status { get; set; } = string.Empty; // e.g., "Present", "Absent", "Late"

        [StringLength(2000)]
        public string Remarks { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }
    }

    public class ResponseAttendanceDTO { 
        public ResponseAttendanceDTO(string studentId, string courseCode, string teacherId, string status, string remarks, DateTime date)
        {
            StudentId = studentId;
            CourseCode = courseCode;
            TeacherId = teacherId;
            Status = status;
            Remarks = remarks;
            Date = date;
        }
        public string StudentId { get; set; } = "24094629";
        public string CourseCode { get; set; } = string.Empty;
        public string TeacherId { get; set; } = "1045";
        public string Status { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.MinValue;
    }
}
