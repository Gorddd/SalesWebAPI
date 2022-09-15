namespace SalesWebAPI.Models
{
    public record SaleData
    {
        public int Id { get; init; }
        public int ProductId { get; init; }
        public int ProductQuantity { get; init; }
        public int ProductIdAmount { get; init; }
    }
}
