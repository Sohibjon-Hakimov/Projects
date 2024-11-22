using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class DepartmentService
{
    private readonly HttpClient _httpClient;

    public DepartmentService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Department>> GetDepartmentsAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Department>>("api/departments");
    }

    // Add more methods for CRUD operations as needed
}
