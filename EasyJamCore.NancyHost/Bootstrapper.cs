namespace EasyJamCore.NancyHost
{
    using System;
    using EasyJamCore.DAL.Modules;
    using EasyJamCore.DAL.Repository;
    using EasyJamCore.DAL.Repository.Implementation;
    using EasyJamCore.NancyHost.AutoMapper;
    using EasyJamCore.Service.Services;
    using EasyJamCore.Service.Services.Implementation;
    using global::AutoMapper;
    using Microsoft.Extensions.DependencyInjection;
    using Nancy;
    using Nancy.Bootstrapper;
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
                throw new ArgumentNullException(nameof(container));
            }

            base.ConfigureApplicationContainer(container);

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ApiAutoMapperConfig());
                mc.AddProfile(new DalAutoMapperConfig());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            container.Register(mapper);
            container.Register<IDancerService, DancerService>();
            container.Register<IDancerRepository, DancerRepository>();
            container.Register(services);
            container.Register(config);
        }

        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            if (pipelines == null)
            {
                throw new ArgumentOutOfRangeException(nameof(pipelines));
            }

            pipelines.AfterRequest.AddItemToEndOfPipeline((ctx) =>
            {
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*")
                                .WithHeader("Access-Control-Allow-Methods", "POST,GET, PUT, DELETE, OPTIONS")
                                .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type");
            });
        }
    }
}
