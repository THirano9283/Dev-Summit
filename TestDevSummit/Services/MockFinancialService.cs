using DevSummit.Models.Financial;

namespace DevSummit.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            return Task.FromResult<List<BoxOfficeRevenueType>>(new());
        }

        public Task<List<SalesType>> GetSales()
        {
            return Task.FromResult<List<SalesType>>(new());
        }
    }
}
