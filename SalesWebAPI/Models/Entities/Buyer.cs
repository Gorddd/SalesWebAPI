namespace SalesWebAPI.Models
{
    public record Buyer
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public List<int> SalesIds { get; init; } = new();
    }
}
