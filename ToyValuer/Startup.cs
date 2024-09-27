using ToyValuer.DataAccess;

namespace ToyValuer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // grabs the connection string from appsettings.json and makes it available throughout service?
            services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));

            services.AddTransient<BalancesRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
        }
    }
}
