using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyJamCore.Common.Model;
using EasyJamCore.DAL.Repository;

namespace EasyJamCore.Service.Services.Implementation
{
    public class DancerService : IDancerService
    {
        private readonly IDancerRepository _dancerRepository;

        public DancerService(IDancerRepository dancerRepository)
        {
            _dancerRepository = dancerRepository;
        }

        public void Create(DancerModel dancer)
        {
            if(dancer == null)
            {
                //TODO : Business Exception
            }
            _dancerRepository.Add(dancer);
        }

        public List<DancerModel> GetAllDancers()
        {
           return _dancerRepository.GetAll().ToList();
        }

        public async Task<DancerModel> GetAsync(int id)
        {
            return await _dancerRepository.GetById(id);
        }
    }
}
