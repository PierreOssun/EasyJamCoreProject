namespace EasyJamCore.NancyHost
{
    using System;
    using AutoMapper;
    using EasyJamCore.DAL.Repository;
    using EasyJamCore.DAL.Repository.Implementation;
    using EasyJamCore.Service.Services;
    using EasyJamCore.Service.Services.Implementation;
    using Microsoft.Extensions.DependencyInjection;
    using Nancy;
    using Nancy.TinyIoc;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        private readonly IServiceCollection services;

        private readonly IAppConfiguration config;

        public Bootstrapper(IAppConfiguration config, IServiceCollection services)
        {
            this.services = services;
            this.config = config;
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(container + " variable request cannot be null");
            }

            base.ConfigureApplicationContainer(container);

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            container.Register<IMapper>(mapper);
            container.Register<IDancerService, DancerService>();
            container.Register<IDancerRepository, DancerRepository>();
            container.Register<IServiceCollection>(services);
            container.Register<IAppConfiguration>(config);
        }
    }
}
