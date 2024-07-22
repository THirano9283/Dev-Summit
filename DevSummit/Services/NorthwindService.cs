using System.Text.Json;
using DevSummit.Models.Northwind;

namespace DevSummit.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly IWebHostEnvironment _env;

        public NorthwindService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<List<EmployeesType>> GetEmployees()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var path = _env.WebRootPath + "/static-data/northwind-employees-type.json";
            if (!File.Exists(path))
            {
                return new List<EmployeesType>();
            }
            var data = File.ReadAllText(path);
            return await Task.FromResult(JsonSerializer.Deserialize<List<EmployeesType>>(data, options));
        }
    }
}
