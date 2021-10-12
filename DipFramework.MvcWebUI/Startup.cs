using DipFramework.Business.Abstract;
using DipFramework.Business.Concrete.Managers;
using DipFramework.Business.DependencyResolvers.Ninject;
using DipFramework.Core.CrossCuttingConcerns.Logging.Log4Net;
using DipFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using DipFramework.DataAccess.EntityFramework.Abstract;
using DipFramework.DataAccess.EntityFramework.Concrete;
using DipFramework.DataAccess.EntityFramework.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ninject.Modules;

namespace DipFramework.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.

            services.AddMvc();

            // Add application services.
            services.AddTransient<IProductService, ProductManager>();
            services.AddTransient<IProductDal, EfProductDal>();

            services.AddLogging();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}");
            });
        }
    }
}
