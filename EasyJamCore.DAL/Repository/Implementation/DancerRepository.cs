using EasyJamCore.Common.Model;
using EasyJamCore.DAL.Entities;

namespace EasyJamCore.DAL.Repository.Implementation
{
    public class DancerRepository : GenericRepository<DancerModel,DancerEntity>, IDancerRepository
    {
        public DancerRepository(EasyJamCoreDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
