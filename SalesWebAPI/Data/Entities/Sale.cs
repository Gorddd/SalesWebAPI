using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public class Sale : IModel
{
    public int Id { get; set; }

    public string Date { get; set; } = null!;

    public string Time { get; set; } = null!;

    public int SalesPointId { get; set; }
    public SalesPoint SalesPoint { get; set; } = null!;

    public int? BuyerId { get; set; }

    public ICollection<SaleData> SalesData { get; set; } = null!;

    public double TotalAmount { get; set; }
}
