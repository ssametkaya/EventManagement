using BusinessLayer.CustomValidator;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace EventManagementWeb.Extensions
{
    public static class StartupExtension
    {
        public static void AddIdentityWithExtension(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;

                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddPasswordValidator<PasswordValidator>().AddEntityFrameworkStores<AppDbContext>();
        }

    }
}
