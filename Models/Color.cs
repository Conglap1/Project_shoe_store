namespace Project_shoe_store.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; } // Ví dụ: Đỏ, Đen
        public string HexCode { get; set; } // Ví dụ: #FF0000 (để hiển thị ô màu trên web)
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
