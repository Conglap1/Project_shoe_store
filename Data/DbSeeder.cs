using Microsoft.AspNetCore.Identity;
using Project_shoe_store.Models;

namespace Project_shoe_store.Data
{
    public static class DbSeeder
    {
        // Hàm này sẽ được gọi khi chạy chương trình
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            // Lấy dịch vụ quản lý User và Role
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();

            // 1. Tạo Role "Admin" và "Customer" nếu chưa có
            await roleManager.CreateAsync(new IdentityRole("Admin"));
            await roleManager.CreateAsync(new IdentityRole("Customer"));

            // 2. Tạo tài khoản Admin mặc định
            var user = await userManager.FindByEmailAsync("admin@gmail.com");
            if (user == null)
            {
                user = new ApplicationUser()
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    FullName = "Quản trị viên", // Thêm property này vì bạn dùng ApplicationUser
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };

                // Mật khẩu bắt buộc có: Chữ hoa, thường, số, ký tự đặc biệt
                await userManager.CreateAsync(user, "Admin@123");

                // Gán quyền Admin cho user này
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
