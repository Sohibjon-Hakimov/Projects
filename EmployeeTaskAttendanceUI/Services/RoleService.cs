using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EmployeeTaskAttendanceUI.Models;

namespace EmployeeTaskAttendanceUI.Services
{
    public class RoleService
    {
        private readonly HttpClient _httpClient;

        public RoleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Role[]> GetRolesAsync()
        {
            return await _httpClient.GetFromJsonAsync<Role[]>("api/roles");
        }

        public async Task CreateRoleAsync(Role role)
        {
            await _httpClient.PostAsJsonAsync("api/roles", role);
        }
    }
}
