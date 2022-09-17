namespace SalesWebAPI.Models;

public record ProvidedProduct
{
    public int Id { get; init; }

    public int SalesPointId { get; init; }

    public int ProductId { get; init; }
    public Product Product { get; init; } = null!;

    public int ProductQuantity { get; init; }
}
