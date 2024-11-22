namespace EmployeeTaskAttendance.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
    }
}
