namespace EasyJamCore.Service.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EasyJamCore.Common.Model;

    public interface IDancerService
    {
        Task<DancerModel> GetAsync(int id);

        void Create(DancerModel dancer);

        List<DancerModel> GetAllDancers();
    }
}