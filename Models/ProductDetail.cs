namespace Project_shoe_store.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int SizeId { get; set; }
        public virtual Size Size { get; set; }

        public int ColorId { get; set; }
        public virtual Color Color { get; set; }

        public int Quantity { get; set; } // Số lượng tồn kho cho Size này, Màu này
    }
}
