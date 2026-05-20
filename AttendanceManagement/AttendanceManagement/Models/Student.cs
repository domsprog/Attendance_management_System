namespace AttendanceManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;// e.g., "John", "Jane"
        public string LastName { get; set; } = string.Empty;// e.g., "Doe", "Smith"
        public string Email { get; set; } = string.Empty;// e.g., "john.doe@example.com"
        public string Status { get; set; } = string.Empty;// e.g., "Present", "Absent", "Excused"
    }
}
