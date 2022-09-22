using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public record Product : IModel
{
    public int Id { get; init; }

    public string Name { get; init; } = null!;

    public double Price { get; init; }
}
