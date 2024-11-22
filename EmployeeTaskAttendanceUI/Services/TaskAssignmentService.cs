using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EmployeeTaskAttendanceUI.Models;

namespace EmployeeTaskAttendanceUI.Services
{
    public class TaskAssignmentService
    {
        private readonly HttpClient _httpClient;

        public TaskAssignmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TaskAssignment[]> GetTaskAssignmentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<TaskAssignment[]>("api/taskassignments");
        }

        public async Task CreateTaskAssignmentAsync(TaskAssignment assignment)
        {
            await _httpClient.PostAsJsonAsync("api/taskassignments", assignment);
        }
    }
}
