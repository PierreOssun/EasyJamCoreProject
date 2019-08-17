using AutoMapper;
using EasyJamCore.Common.Model;
using EasyJamCore.DAL.Entities;
using EasyJamCore.DAL.Repository;
using EasyJamCore.DAL.Repository.Implementation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyJamCore.API.Controllers
{
    [Route("api/Dancers")]
    [ApiController]
    public class DancerController : Controller
    {
        private IDancerRepository iiDancerRepository;
        public DancerController(EasyJamCoreDbContext context, IMapper mapper)
        {
            iiDancerRepository = new DancerRepository(context, mapper);
        }

        [HttpGet("GetDancers")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value3", "value2" };
        }

        [HttpPost("PostDancers")]  
        public void Create(DancerModel dancer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    iiDancerRepository.Add(dancer);
                    iiDancerRepository.SaveAsync();
                }
            }
            catch (System.Exception e)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
                throw e;
            }
        }
    }
}
