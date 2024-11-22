namespace EmployeeTaskAttendance.Models
{
    public class TaskItem
    {
        public int TaskItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
