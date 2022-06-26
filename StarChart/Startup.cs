using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StarChart.Data;
using Microsoft.EntityFrameworkCore;

namespace StarChart
{
    public class Startup
    {
        // This method gets called by the runtime. This method will add services to the container.
        // Adds MVC method to services to support MVC MiddleWare
        // Adds DBContext on Services with argument pointing EntityFramework to the applications DbContext.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("StarChart"));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();   
        }
    }
}
