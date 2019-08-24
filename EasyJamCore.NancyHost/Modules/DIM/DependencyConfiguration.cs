using EasyJamCore.DAL.Repository;
using EasyJamCore.DAL.Repository.Implementation;
using EasyJamCore.Service.Services;
using EasyJamCore.Service.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace EasyJamCore.NancyHost.DIM.Implementation
{
    public class DependencyConfiguration
    {
        public static void ConfiguredDependencyInjection(IServiceCollection services)
        {
            //Repositories
            services.AddScoped<IDancerRepository, DancerRepository>();

            //Services
            services.AddSingleton<IDancerService, DancerService>();
        }
    }
}
