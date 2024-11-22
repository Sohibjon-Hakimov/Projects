using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EmployeeTaskAttendanceUI.Models;

namespace EmployeeTaskAttendanceUI.Services
{
    public class TaskService
    {
        private readonly HttpClient _httpClient;

        public TaskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TaskItem[]> GetTasksAsync()
        {
            return await _httpClient.GetFromJsonAsync<TaskItem[]>("api/tasks");
        }

        public async Task<TaskItem> GetTaskByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<TaskItem>($"api/tasks/{id}");
        }

        public async Task CreateTaskAsync(TaskItem task)
        {
            await _httpClient.PostAsJsonAsync("api/tasks", task);
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            await _httpClient.PutAsJsonAsync($"api/tasks/{task.TaskId}", task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/tasks/{id}");
        }
    }
}
