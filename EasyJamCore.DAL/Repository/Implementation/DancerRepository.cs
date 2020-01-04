namespace EasyJamCore.DAL.Repository.Implementation
{
    using AutoMapper;
    using EasyJamCore.Common.Model;
    using EasyJamCore.DAL.Entities;

    public class DancerRepository : GenericRepository<DancerModel, DancerEntity>, IDancerRepository
    {
        public DancerRepository(EasyJamCoreDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
    }
}
