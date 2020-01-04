namespace EasyJamCore.API.Controllers
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using EasyJamCore.Common.Model;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/Dancers")]
    [ApiController]
    public class DancerController : Controller
    {
        // GET api/
        [HttpGet("GetDancerById")]
        public async Task<IActionResult> GetDancerById(int id)
        {
            string url = "https://localhost/5000/dancer/{id}";

            using (HttpClient client = new HttpClient())
            {
                return Json(await client.GetStringAsync(url).ConfigureAwait(false));
            }

            // var result = _authorRepository.GetByNameSubstring(namelike);
            // if (!result.Any())
            // {
            //    return NotFound(namelike);
            // }
            // return Ok(result);

            // var dancer = await _dancerService.GetAsync(request.Id);
        }

        [HttpPost("PostDancers")]
        public void Create(DancerModel dancer)
        {
        }
    }
}