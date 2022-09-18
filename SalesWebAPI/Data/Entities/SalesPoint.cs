namespace SalesWebAPI.Models;

public record SalesPoint
{
    public int Id { get; init; }

    public string Name { get; init; } = null!;

    public ICollection<ProvidedProduct> ProvidedProducts { get; init; } = null!;
}