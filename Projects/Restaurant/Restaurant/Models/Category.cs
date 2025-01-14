namespace Restaurant.Models
{
    public class Category
    {
        public int CatgeoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}