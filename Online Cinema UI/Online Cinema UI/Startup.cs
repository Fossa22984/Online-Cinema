using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Online_Cinema_BLL.Infrastructure;
using Online_Cinema_BLL.Services;
using Online_Cinema_BLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Cinema_UI
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
            BllConfiguration.Configuration(services, Configuration.GetConnectionString("DefaultConnection"));

            var option = new SendGridOptions();
            Configuration.GetSection("SendGridOptions").Bind(option);
            services.AddTransient<SendGridOptions>(x => option);

            services.AddTransient<IEmailSender, EmailSender>();

            //services.AddTransient(typeof(Test));

            services.AddAuthentication().AddCookie(op => op.LoginPath = "/Login");
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Account/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
