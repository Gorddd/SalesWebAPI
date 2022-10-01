using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public class SalesPoint : IModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<ProvidedProduct> ProvidedProducts { get; set; } = null!;
}