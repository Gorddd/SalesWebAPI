namespace SalesWebAPI.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<int> SalesIds { get; set; } = new();
    }
}
