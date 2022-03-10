﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mission10Final.Models;

namespace Mission10Final
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<Models.BookContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("BookConnection"));
            });

            // Identity
            services.AddDbContext<AppIdentityDBContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("IdentityConnection"));
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDBContext>();

            services.AddScoped<Models.IBookRepository, Models.EFBookRepository>();
            services.AddScoped<IShopperRepository, EFShopperRepository>();
            services.AddRazorPages();

            services.AddDistributedMemoryCache();

            services.AddSession();

            services.AddScoped<Basket>(x => SessionBasket.GetBasket(x));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Add Server-side blazor

            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            // enabling to use session storage
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "categorypage",
                   pattern: "{categoryType}/Page{pageNum}",
                   defaults: new { Controller = "Home", action = "Index" }
               );

                endpoints.MapControllerRoute(
                name: "Paging",
                pattern: "Page{pageNum}",
                defaults: new { Controller = "Home", action = "Index", pageNum = 1 }
                );

                endpoints.MapControllerRoute(
                    name: "category",
                    pattern: "{categoryType}",
                    defaults: new { Controller = "Home", action = "Index", pageNum = 1 }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                // Enabling to route through cshtml in Pages folder
                endpoints.MapRazorPages();

                // Enabling blazor to this application and set a default path
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");
            });

            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
