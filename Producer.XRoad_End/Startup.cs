using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Producer.Data;
using Producer.Service;
using Producer.XRoad_End.ServiceContract;
using XRoadLib.Extensions.AspNetCore;

namespace Producer.XRoad_End
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = _configuration.GetConnectionString(nameof(AppDbContext));

            services.AddDbContext<AppDbContext>(
                options => options.UseNpgsql(connectionString));

            services.AddScoped<IPersonService, PersonService>();

            services.AddScoped<IPersonSoapService, PersonSoapService>();

            services.AddScoped<PersonSoapServiceManager>();

            services.AddXRoadLib();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseXRoadLib(routeBuilder =>
            {
                routeBuilder.MapWsdl<PersonSoapServiceManager>("");
                routeBuilder.MapWebService<PersonSoapServiceManager>("");
            });
        }
    }
}
