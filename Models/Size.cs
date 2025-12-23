namespace Project_shoe_store.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string Value { get; set; } // Ví dụ: 39, 40, 41, 42
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
