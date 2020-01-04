namespace EasyJamCore.Service.Services.Implementation
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EasyJamCore.Common.Model;
    using EasyJamCore.DAL.Repository;

    public class DancerService : IDancerService
    {
        private readonly IDancerRepository dancerRepository;

        public DancerService(IDancerRepository dancerRepository)
        {
            this.dancerRepository = dancerRepository;
        }

        public void Create(DancerModel dancer)
        {
            if (dancer == null)
            {
                // TODO : Business Exception
            }

            dancerRepository.Add(dancer);
        }

        public List<DancerModel> GetAllDancers()
        {
           return dancerRepository.GetAll().ToList();
        }

        public async Task<DancerModel> GetAsync(int id)
        {
            return await dancerRepository.GetById(id).ConfigureAwait(false);
        }
    }
}
