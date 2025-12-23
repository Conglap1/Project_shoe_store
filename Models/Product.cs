using System.ComponentModel.DataAnnotations.Schema;

namespace Project_shoe_store.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } // Tên giày: Nike Air Jordan
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } // Giá bán
        public string? ImageUrl { get; set; } // Ảnh đại diện chính

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // Một sản phẩm có nhiều biến thể (Size/Màu)
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
