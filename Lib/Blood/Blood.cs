using Microsoft.OpenApi.Models;

namespace HajurKoCarRental.Lib.Blood;

public static class Blood
{
    public static void InitializeDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "HajurKoCarRental API", Version = "v1" });
        });

        /*builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();


        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.Cookie.Name = "__CarRental_";
                options.ExpireTimeSpan = TimeSpan.FromDays(365);
                options.LoginPath = "/Auth/Login";
            });*/
    }
}