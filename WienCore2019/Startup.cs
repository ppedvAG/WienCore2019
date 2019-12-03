using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WienCore2019.Modul02;
using WienCore2019.Pages.Modul05;

namespace WienCore2019
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
            services.AddRazorPages();
            services.AddSingleton<DI>();
            services.AddSession(options=>options.IdleTimeout=new TimeSpan(0,30,0));
            services.AddResponseCaching();
            services.AddMemoryCache();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            AppDomain.CurrentDomain.SetData("pfad", env.ContentRootPath); 
            var con = Configuration.GetConnectionString("demo");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();
            app.UseResponseCaching();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
            app.MapWhen(context => context.Request.Path.Value.Contains("thumbnail"), appBranch =>
              {
                  appBranch.UseMiddleware<Thumbnail>();
              });
        }
    }
}
