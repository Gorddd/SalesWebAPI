namespace SalesWebAPI.Models
{
    public class SalesPoint
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<ProvidedProduct> ProvidedProducts { get; set; } = new();
    }
}
