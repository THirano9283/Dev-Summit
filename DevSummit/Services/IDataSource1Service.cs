using DevSummit.Models.DataSource1;

namespace DevSummit.DataSource1
{
    public interface IDataSource1Service
    {
        Task<List<Product>> GetProductList();
        Task<Product> PutProduct(object? data);
        Task<Product> DeleteProduct(string? id);
        Task<Product> PostProduct(object? data);
    }
}
