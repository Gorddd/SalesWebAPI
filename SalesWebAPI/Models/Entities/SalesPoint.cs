namespace SalesWebAPI.Models
{
    public record SalesPoint
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public List<ProvidedProduct> ProvidedProducts { get; init; } = new();
    }
}
