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
using SourceStack.Filters;

namespace SourceStack
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
            //services.AddRazorPages();

            services.AddRazorPages()
                //.AddMvcOptions(opt=>opt.Filters.Add<IsShowLogOnAttribute>())//添加全局Filter 调用泛型方法
                 // .AddMvcOptions(opt => opt.Filters.Add(typeof(IsShowLogOnAttribute)))//添加全局Filter 调用普通方法
              .AddRazorPagesOptions(opt =>
       {
           opt.Conventions.AddPageRoute("/Log/On", "/LogOn");
           opt.Conventions.AddPageRoute("/Article/Index", "/Article/Categary-{id:int}");
            opt.Conventions.AddPageRoute("/Article/Index", "/Article/Paged{id}");
           opt.Conventions.AddPageRoute("/Article/Single", "/Article/{id}");
       });


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

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
