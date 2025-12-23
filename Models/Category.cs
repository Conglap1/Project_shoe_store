using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace Project_shoe_store.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } // Ví dụ: Giày chạy bộ, Giày tây
        public virtual ICollection<Product> Products { get; set; }
    }
}
