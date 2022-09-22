using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public record SaleData : IModel
{
    public int Id { get; init; }

    public int ProductId { get; init; }
    public Product Product { get; init; } = null!;

    public int ProductQuantity { get; init; }

    public int ProductIdAmount { get; init; }

    public int SaleId { get; init; }
}
