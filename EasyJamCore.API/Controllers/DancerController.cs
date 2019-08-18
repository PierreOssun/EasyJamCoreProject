using AutoMapper;
using EasyJamCore.Common.Model;
using EasyJamCore.DAL.Entities;
using EasyJamCore.DAL.Repository;
using EasyJamCore.DAL.Repository.Implementation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyJamCore.API.Controllers
{
    [Route("api/Dancers")]
    [ApiController]
    public class DancerController : Controller
    {
        private readonly IDancerRepository iiDancerRepository;
        public DancerController(IDancerRepository dancerRepository)
        {
            iiDancerRepository = dancerRepository;
        }

        [HttpGet("GetDancerById")]
        public async Task<IActionResult> GetDancerById(int id)
        {
            var dancer = iiDancerRepository.GetById(id);

            if(dancer == null)
            {
                return NotFound();
            }

            return View(dancer);
        }

        [HttpPost("PostDancers")]  
        public void Create(DancerModel dancer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    iiDancerRepository.Add(dancer);
                    iiDancerRepository.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
                throw e;
            }
        }
    }
}
