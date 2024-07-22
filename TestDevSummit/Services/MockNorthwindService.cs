using DevSummit.Models.Northwind;

namespace DevSummit.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<EmployeesType>> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>>(new());
        }
    }
}
