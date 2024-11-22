using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EmployeeTaskAttendanceUI.Models;

namespace EmployeeTaskAttendanceUI.Services
{
    public class LeaveRequestService
    {
        private readonly HttpClient _httpClient;

        public LeaveRequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LeaveRequest[]> GetLeaveRequestsAsync()
        {
            return await _httpClient.GetFromJsonAsync<LeaveRequest[]>("api/leaverequests");
        }

        public async Task CreateLeaveRequestAsync(LeaveRequest leaveRequest)
        {
            await _httpClient.PostAsJsonAsync("api/leaverequests", leaveRequest);
        }
    }
}
