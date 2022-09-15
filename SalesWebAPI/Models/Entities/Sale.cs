namespace SalesWebAPI.Models
{
    public record Sale
    {
        public int Id { get; init; }
        public string Date { get; init; } = null!;
        public string Time { get; init; } = null!;
        public int SalesPointId { get; init; }
        public int? BuyerId { get; init; }
        public List<SaleData> SalesData { get; init; } = new();
        public int TotalAmount { get; init; }
    }
}
