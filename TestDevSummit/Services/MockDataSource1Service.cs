using DevSummit.Models.DataSource1;

namespace DevSummit.DataSource1
{
    public class MockDataSource1Service : IDataSource1Service
    {
        public Task<List<Product>> GetProductList()
        {
            return Task.FromResult<List<Product>>(new());
        }

        public Task<Product> PutProduct(object? data)
        {
            return Task.FromResult<Product>(new());
        }

        public Task<Product> DeleteProduct(string? id)
        {
            return Task.FromResult<Product>(new());
        }

        public Task<Product> PostProduct(object? data)
        {
            return Task.FromResult<Product>(new());
        }
    }
}
