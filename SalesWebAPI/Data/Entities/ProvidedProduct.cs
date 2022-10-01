using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public class ProvidedProduct : IModel
{
    public int Id { get; set; }

    public int SalesPointId { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int ProductQuantity { get; set; }
}
