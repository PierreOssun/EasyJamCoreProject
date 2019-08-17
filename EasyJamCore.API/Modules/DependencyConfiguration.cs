using EasyJamCore.DAL.Repository;
using EasyJamCore.DAL.Repository.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace EasyJamCore.API.Modules
{
    public static class DependencyConfiguration
    {
        public static void ConfiguredDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IDancerRepository, DancerRepository>();
        }
    }
}
