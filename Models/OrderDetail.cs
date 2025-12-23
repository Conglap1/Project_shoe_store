using System.ComponentModel.DataAnnotations.Schema;

namespace Project_shoe_store.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        // Link tới ProductDetail để biết khách mua Size nào, Màu nào
        public int ProductDetailId { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; } // Lưu giá tại thời điểm mua (đề phòng giá SP thay đổi sau này)
    }
}
