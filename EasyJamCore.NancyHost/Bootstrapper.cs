using AutoMapper;
using EasyJamCore.DAL.Repository;
using EasyJamCore.DAL.Repository.Implementation;
using EasyJamCore.Service.Services;
using EasyJamCore.Service.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Nancy;
using Nancy.TinyIoc;

namespace EasyJamCore.NancyHost
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        public IServiceCollection Services;

        private IAppConfiguration Config;

        public Bootstrapper(IAppConfiguration config, IServiceCollection services)
        {
            Services = services;
            this.Config = config;
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            container.Register<IMapper>(mapper);
            container.Register<IDancerService, DancerService>();
            container.Register<IDancerRepository, DancerRepository>();
            container.Register<IServiceCollection>(Services);
            container.Register<IAppConfiguration>(Config);
        }
    }
}
