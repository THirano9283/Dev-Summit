namespace DevSummit.Models.DataSource1;

public class Product
{
    public string Id { get; set; }
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public string Recommendations { get; set; }
    public DateTime SalesStartDate { get; set; }
    public DateTime SalesEndDate { get; set; }
    public double UnitPrice { get; set; }
}
