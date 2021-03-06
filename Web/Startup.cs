using Core.Entities;
using Core.Interfaces;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Web
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        /* !AhmedShaban: Constructor to inject the dependency of
         * configurations from appsettings.json
         */
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //!AhmedShaban: Enable Controllers
            services.AddControllers();
            //!AhmedShaban: Add the Database Context.
            services.AddDbContext<DataContext>(options =>
            {
                //!AhmedShaban:  Add Database Provider and configure connection string
                options.UseSqlServer(configuration.GetConnectionString("TaskDB"));
            });

            //AhmedShaban: Register the Repository Service
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //!AhmedShaban: Map the Controller url pattern
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=App}/{action=Index}/{id?}");
            });
        }
    }
}
