namespace E_commerce.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Imge { get; set; }
        public Category Category { get; set; }
        public Order? Order { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}
