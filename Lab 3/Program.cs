using Data;
using Lab_3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Lab3 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                        var connectionString = builder.Configuration.GetConnectionString("AppDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

            // Add services to the container.
            
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            builder.Services.AddSession();
            builder.Services.AddTransient<IContactService, EFContactService>();
            builder.Services.AddSingleton<IDateTimeProvider, CurrentDateTimeProvider>();
            builder.Services.AddDbContext<AppDbContext>();
                        builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>() 
                .AddEntityFrameworkStores<AppDbContext>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.MapRazorPages();

            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
      
    }

   
}