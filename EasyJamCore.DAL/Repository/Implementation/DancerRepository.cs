using EasyJamCore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyJamCore.DAL.Repository.Implementation
{
    public class DancerRepository : GenericRepository<DancerEntity>, IDancerRepository
    {
        public DancerRepository(EasyJamCoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
