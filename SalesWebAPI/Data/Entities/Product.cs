namespace SalesWebAPI.Models;

public record Product
{
    public int Id { get; init; }

    public string Name { get; init; } = null!;

    public double Price { get; init; }
}
