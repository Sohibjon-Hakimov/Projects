namespace EmployeeTaskAttendance.Models
{
    public class TaskAssignment
    {
        public int TaskAssignmentId { get; set; }
        public int TaskItemId { get; set; }
        public TaskItem Task { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
