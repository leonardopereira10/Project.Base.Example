using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Base.Example.Contracts.ServiceContracts;
using Project.Base.Example.Domain.Repositories.Interfaces;
using Project.Base.Example.Domain.Services;
using Project.Base.Example.Repository;

namespace Project.Base.Example.Startup
{
    public static class MyDependencyInjection
    {
        public static void AddDependencyResolutions(this IServiceCollection services)
        {
            AddDatabeseResolution(services);
            AddServicesResolution(services);
        }

        public static void ExecuteMigrations(this IApplicationBuilder application)
        {
            IServiceScope scope = application.ApplicationServices.CreateScope();
            MyDbContext db = scope.ServiceProvider.GetRequiredService<MyDbContext>();

            db.Database.Migrate();
        }

        private static void AddServicesResolution(IServiceCollection services)
        {
            _ = services.AddTransient<ICityService, CityService>();
        }

        private static void AddDatabeseResolution(IServiceCollection services)
        {
            _ = services.AddDbContext<MyDbContext>(options =>
            {
                _ = options.UseSqlServer(
                    "Data Source='192.168.1.9';Database='Example';User Id='sa';Password='admin';Trusted_Connection=false;MultipleActiveResultSets=true;TrustServerCertificate=true;"
                  , opt => opt.MigrationsAssembly("Project.Base.Example.Repository"));
            });

            _ = services.AddTransient<ICityRepository, CityRepository>();
        }
    }
}