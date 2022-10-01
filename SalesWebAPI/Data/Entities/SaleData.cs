using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public class SaleData : IModel
{
    public int Id { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int ProductQuantity { get; set; }

    public int ProductIdAmount { get; set; }

    public int SaleId { get; set; }
}
