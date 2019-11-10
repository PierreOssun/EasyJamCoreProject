using EasyJamCore.Common.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyJamCore.API.Controllers
{
    [Route("api/Dancers")]
    [ApiController]
    public class DancerController : Controller
    {
        //[HttpGet("GetDancerById")]
        //public async Task<IActionResult> GetDancerById(int id)
        //{
        //}

        [HttpPost("PostDancers")]
        public void Create(DancerModel dancer)
        {
        }
    }
}
