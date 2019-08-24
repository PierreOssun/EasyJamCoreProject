using EasyJamCore.NancyHost.Request;
using EasyJamCore.NancyHost.Responses;
using EasyJamCore.Service.Services;
using Nancy;
using System.Threading.Tasks;

namespace EasyJamCore.NancyHost.Modules
{
    public class DancerModule : NancyModule
    {
        readonly IDancerService _dancerService;
        public DancerModule(IAppConfiguration appConfig, IDancerService dancerService)
        {
            _dancerService = dancerService;

            Get("/dancer/", args => AllDancers());

            Get("/dancer/", args => GetDancer(args));
        }

        public DancersResponse AllDancers()
        {
            return new DancersResponse
            {
                Dancers = _dancerService.GetAllDancers()
            };
        }

        public async Task<object> GetDancer(DancerRequest request)
        {
            var dancer = await _dancerService.GetAsync(request.Id);
            if(dancer == null)
            {
                return HttpStatusCode.NotFound;
            }
            return dancer;
        }
    }
}