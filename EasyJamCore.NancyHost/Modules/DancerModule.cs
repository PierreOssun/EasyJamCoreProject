namespace EasyJamCore.NancyHost.Modules
{
    using System;
    using System.Threading.Tasks;
    using EasyJamCore.Common.DTO;
    using EasyJamCore.Common.Model;
    using EasyJamCore.NancyHost.Responses;
    using EasyJamCore.Service.Services;
    using global::AutoMapper;
    using Nancy;

    public class DancerModule : NancyModule
    {
        private readonly IDancerService dancerService;
        private readonly IMapper mapper;

        public DancerModule(IDancerService dancerService, IMapper mapper)
            : base("/dancer")
        {
            this.mapper = mapper;
            this.dancerService = dancerService ?? throw new ArgumentNullException(nameof(dancerService));

            Get("/dancers", args => AllDancers());

            Get("/{Id}", async x => await GetDancer(x.Id));
        }

        public DancersResponse AllDancers()
        {
            return new DancersResponse
            {
                Dancers = dancerService.GetAllDancers(),
            };
        }

        public async Task<DancerDto> GetDancer(int id)
        {
            DancerModel model = await dancerService.GetAsync(id).ConfigureAwait(false);
            return mapper.Map<DancerDto>(model);
        }
    }
}