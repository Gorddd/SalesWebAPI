using SalesWebAPI.Data;

namespace SalesWebAPI.Models;

public class Product : IModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }
}
