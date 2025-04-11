namespace E_commerce.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Price { get; set; }
        public User User { get; set; }
        public List<Product> products { get; set; }
    }
}
