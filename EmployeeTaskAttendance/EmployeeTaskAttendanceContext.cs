using Microsoft.EntityFrameworkCore;
using EmployeeTaskAttendance.Models;

namespace EmployeeTaskAttendance
{
    public class EmployeeTaskAttendanceContext : DbContext
    {
        public EmployeeTaskAttendanceContext(DbContextOptions<EmployeeTaskAttendanceContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<TaskAssignment> TaskAssignments { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
