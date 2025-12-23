using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace Project_shoe_store.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; } // Ví dụ: Nike, Adidas
        public string? Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
