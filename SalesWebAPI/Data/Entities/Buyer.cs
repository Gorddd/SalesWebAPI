using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public record Buyer : IModel
{
    public int Id { get; init; }

    public string Name { get; init; } = null!;

    public ICollection<Sale> SalesIds { get; init; } = null!;
}
