using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EmployeeTaskAttendanceUI.Models;

namespace EmployeeTaskAttendanceUI.Services
{
    public class ProjectService
    {
        private readonly HttpClient _httpClient;

        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Project[]> GetProjectsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Project[]>("api/projects");
        }

        public async Task CreateProjectAsync(Project project)
        {
            await _httpClient.PostAsJsonAsync("api/projects", project);
        }
    }
}
