namespace EasyJamCore.API.Controllers
{
    using System.Threading.Tasks;
    using EasyJamCore.API.ControllerHelpers;
    using EasyJamCore.Common.DTO;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;

    [Route("api/Dancers")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class DancerController : Controller
    {
        private static string baseUri;

        public DancerController(IConfiguration config)
        {
            baseUri = config.GetValue<string>("NancyBaseUrl");
        }

        [HttpGet("GetDancerById")]
        public async Task<DancerDto> GetDancerById(int id)
        {
            var getDancer = await ClientHelper.CallGET(baseUri, $"/dancer", id.ToString()).ConfigureAwait(false);
            DancerDto resultset = JsonConvert.DeserializeObject(getDancer, typeof(DancerDto)) as DancerDto;
            return resultset;
        }

        [HttpPost("PostDancers")]
        public void Create(DancerDto dancer)
        {
        }
    }
}