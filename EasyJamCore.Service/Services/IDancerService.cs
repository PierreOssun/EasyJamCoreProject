using EasyJamCore.Common.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyJamCore.Service.Services
{
    public interface IDancerService
    {
        Task<DancerModel> GetAsync(int id);

        void Create(DancerModel dancer);

        List<DancerModel> GetAllDancers();
    }
}