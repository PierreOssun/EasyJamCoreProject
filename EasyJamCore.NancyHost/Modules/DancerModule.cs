namespace EasyJamCore.NancyHost.Modules
{
    using System;
    using System.Threading.Tasks;
    using EasyJamCore.NancyHost.Request;
    using EasyJamCore.NancyHost.Responses;
    using EasyJamCore.Service.Services;
    using Nancy;

    public class DancerModule : NancyModule
    {
        private readonly IDancerService dancerService;

        public DancerModule(IDancerService dancerService)
        {
            this.dancerService = dancerService ?? throw new ArgumentNullException(nameof(dancerService));

            Get("/dancers/", args => AllDancers());

            Get("/dancer/", args => GetDancer(args));
        }

        public DancersResponse AllDancers()
        {
            return new DancersResponse
            {
                Dancers = dancerService.GetAllDancers(),
            };
        }

        public async Task<object> GetDancer(DancerRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(request + " variable request cannot be null");
            }

            var dancer = await dancerService.GetAsync(request.Id).ConfigureAwait(false);
            return dancer == null ? HttpStatusCode.NotFound : (object)dancer;
        }
    }
}