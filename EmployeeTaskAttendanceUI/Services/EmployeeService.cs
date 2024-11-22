using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EmployeeTaskAttendanceUI.Models;

namespace EmployeeTaskAttendanceUI.Services
{
    public class EmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Employee[]> GetEmployeesAsync()
        {
            return await _httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task CreateEmployeeAsync(Employee employee)
        {
            await _httpClient.PostAsJsonAsync("api/employees", employee);
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            await _httpClient.PutAsJsonAsync($"api/employees/{employee.EmployeeId}", employee);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/employees/{id}");
        }
    }
}
