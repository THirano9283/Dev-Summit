using DevSummit.Models.Northwind;

namespace DevSummit.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>> GetEmployees();
    }
}
