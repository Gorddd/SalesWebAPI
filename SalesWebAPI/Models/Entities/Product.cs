namespace SalesWebAPI.Models
{
    public record Product
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int Price { get; init; }
    }
}
