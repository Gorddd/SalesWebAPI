using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public class Buyer : IModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<Sale> SalesIds { get; set; } = null!;
}
