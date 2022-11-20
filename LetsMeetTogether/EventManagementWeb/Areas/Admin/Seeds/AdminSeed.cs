using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace EventManagementWeb.Areas.Admin.Seeds
{
    public static class AdminSeed
    {
        public static async Task<IApplicationBuilder> PrepareDatabase(this IApplicationBuilder applicationBuilder)
        {
            using var scopedService = applicationBuilder.ApplicationServices.CreateScope();

            var serviceProvider = scopedService.ServiceProvider;

            await Seed(serviceProvider);

            return applicationBuilder;
        }

        public static async Task Seed(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<AppRole>>();

            var user = new AppUser()
            {
                NameSurname = "Admin admin",
                UserName = "admin",
                Email = "admin@admin.com",

            };

            if (await userManager.FindByEmailAsync("admin@admin.com") == null)
            {
                var IdentityResult = await userManager.CreateAsync(user, "admin123");
            }

            if (await roleManager.FindByNameAsync("Admin") == null)
            {
                AppRole role = new AppRole()
                {
                    Name = "Admin",
                };
                var IdentityResult = await roleManager.CreateAsync(role);
                var Result = await userManager.AddToRoleAsync(user, role.Name);
            }

        }
    }
}
