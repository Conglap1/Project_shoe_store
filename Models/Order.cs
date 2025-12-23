using System.ComponentModel.DataAnnotations.Schema;

namespace Project_shoe_store.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string UserId { get; set; } // Link tới bảng User
        public virtual ApplicationUser User { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; } // Pending, Shipping, Completed, Cancelled
        public string ShippingAddress { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
