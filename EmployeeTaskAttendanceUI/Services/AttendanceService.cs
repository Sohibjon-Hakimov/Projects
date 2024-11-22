using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EmployeeTaskAttendanceUI.Models;

namespace EmployeeTaskAttendanceUI.Services
{
    public class AttendanceService
    {
        private readonly HttpClient _httpClient;

        public AttendanceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Attendance[]> GetAttendancesAsync()
        {
            return await _httpClient.GetFromJsonAsync<Attendance[]>("api/attendances");
        }

        public async Task CreateAttendanceAsync(Attendance attendance)
        {
            await _httpClient.PostAsJsonAsync("api/attendances", attendance);
        }
    }
}
