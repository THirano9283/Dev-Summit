using DevSummit.Models.Financial;

namespace DevSummit.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
        Task<List<SalesType>> GetSales();
    }
}
