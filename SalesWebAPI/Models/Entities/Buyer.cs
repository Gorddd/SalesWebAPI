namespace SalesWebAPI.Models
{
    public record Buyer
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public List<Sale> SalesIds { get; init; } = new();
    }
}
