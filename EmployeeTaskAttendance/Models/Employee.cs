namespace EmployeeTaskAttendance.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

                // Constructor to initialize non-nullable properties
        public Employee()
        {
            Department = string.Empty;  // Default value to ensure non-null
            Position = string.Empty;    // Default value to ensure non-null
        }
    }
}
