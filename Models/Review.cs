namespace E_commerce.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
