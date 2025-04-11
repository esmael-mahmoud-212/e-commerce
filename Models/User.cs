namespace E_commerce.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public List<Order>? Orders { get; set; }
        public List<Product>? Products { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}
