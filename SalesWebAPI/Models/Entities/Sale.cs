namespace SalesWebAPI.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string Date { get; set; } = null!;
        public string Time { get; set; } = null!;
        public int SalesPointId { get; set; }
        public int? BuyerId { get; set; }
        public List<SaleData> SalesData { get; set; } = new();
        public int TotalAmount { get; set; }
    }
}
