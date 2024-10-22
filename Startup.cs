using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Threading.Tasks;
using Verdon.Areas.Identity;
using Verdon.Core.Base;
using Verdon.Data;
using Verdon.Services;



namespace Verdon
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("sqlite")));
            services.AddDbContext<QuizDbContext>(options =>
               options.UseSqlite(Configuration.GetConnectionString("sqlite")));
            services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<User>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<MailSettings>();
            services.AddSingleton<MailService>();
            services.AddTransient<UserService>();
            services.AddTransient<User>();
            services.AddTransient<UploadController>();
            services.AddHttpContextAccessor();
            services.AddHttpClient();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db
            )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/");
                app.UseHsts();
            }


            //seed users & departments before deployment
            SeedService.SeedData(userManager, roleManager, db);

            //configure current directory permission
            FileIOPermission currentDirectory = new FileIOPermission(FileIOPermissionAccess.AllAccess, Directory.GetCurrentDirectory());
            currentDirectory.Demand();


            // configure static file permission
            FileIOPermission permission = new FileIOPermission(FileIOPermissionAccess.AllAccess, Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", "StaticFiles"));
            permission.Demand();


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", "StaticFiles")),
                RequestPath = new PathString("/wwwroot/StaticFiles")
            });
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            
        }
    }
}
