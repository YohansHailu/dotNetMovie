using Microsoft.AspNetCore.Identity;
using Movies.Models;

namespace MovieCrud;
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<UserDbContext>()
            .AddDefaultTokenProviders();
        
        
        services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequiredLength = 6; // Set minimum password length to 8 characters
            options.Password.RequireUppercase = false; // Require at least one uppercase character
            options.Password.RequireLowercase = false; // Require at least one lowercase character
            options.Password.RequireDigit = false; // Require at least one numeric character
            options.Password.RequireNonAlphanumeric = false; // Require at least one special character
        });
            
    }
    public void Configure(IApplicationBuilder app)
    {
    }

}
