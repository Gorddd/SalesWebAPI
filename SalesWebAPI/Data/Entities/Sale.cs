namespace SalesWebAPI.Models;

public record Sale
{
    public int Id { get; init; }

    public string Date { get; init; } = null!;

    public string Time { get; init; } = null!;

    public int SalesPointId { get; init; }
    public SalesPoint SalesPoint { get; init; } = null!;

    public int? BuyerId { get; init; }

    public List<SaleData> SalesData { get; init; } = null!;

    public double TotalAmount { get; init; }
}
