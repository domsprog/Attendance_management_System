

namespace AttendanceManagement.Models
{
    public class Attendance
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string AssigingProfessor { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // e.g., "Present", "Absent", "Late"
        public string Remarks { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
