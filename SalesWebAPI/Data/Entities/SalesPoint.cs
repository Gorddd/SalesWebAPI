using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public record SalesPoint : IModel
{
    public int Id { get; init; }

    public string Name { get; init; } = null!;

    public ICollection<ProvidedProduct> ProvidedProducts { get; init; } = null!;
}