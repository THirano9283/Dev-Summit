using System.Net.Http.Json;
using DevSummit.Models.DataSource1;

namespace DevSummit.DataSource1
{
    public class DataSource1Service: IDataSource1Service
    {
        private readonly HttpClient _http;

        public DataSource1Service(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Product>> GetProductList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://doughnut-shop-demo1-api.azurewebsites.net/products", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<Product>>().ConfigureAwait(false);
            }

            return new List<Product>();
        }

        public async Task<Product> PutProduct(object? data)
        {
            if (data == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, new Uri("https://doughnut-shop-demo1-api.azurewebsites.net/products", UriKind.RelativeOrAbsolute));
            request.Content = new StringContent(@"{
  ""id"": ""string"",
  ""productCode"": ""string"",
  ""productName"": ""string"",
  ""description"": ""string"",
  ""recommendations"": ""string"",
  ""salesStartDate"": ""string"",
  ""salesEndDate"": ""string"",
  ""unitPrice"": 123
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Product>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<Product> DeleteProduct(string? id)
        {
            if (id == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, new Uri($"https://doughnut-shop-demo1-api.azurewebsites.net/products/{id}", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Product>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<Product> PostProduct(object? data)
        {
            if (data == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, new Uri("https://doughnut-shop-demo1-api.azurewebsites.net/products", UriKind.RelativeOrAbsolute));
            request.Content = new StringContent(@"{
  ""id"": ""string"",
  ""productCode"": ""string"",
  ""productName"": ""string"",
  ""description"": ""string"",
  ""recommendations"": ""string"",
  ""salesStartDate"": ""string"",
  ""salesEndDate"": ""string"",
  ""unitPrice"": 123
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Product>().ConfigureAwait(false);
            }

            return null;
        }
    }
}
