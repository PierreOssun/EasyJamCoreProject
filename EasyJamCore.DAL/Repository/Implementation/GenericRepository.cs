using AutoMapper;
using EasyJamCore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyJamCore.DAL.Repository.Implementation
{
    public class GenericRepository<TModel,TEntity> : IGenericRepository<TModel, TEntity>
        where TEntity  : class
        where TModel : class
    {
        public IEnumerable<TModel> GetAll()
        {
            var entities = _dbContext.Set<TEntity>().AsNoTracking();
            return _mapper.Map<IEnumerable<TModel>>(entities).AsEnumerable();
        }

        public async Task Add(TModel model)
        {
            try
            {
                var entity = _mapper.Map<TModel, TEntity>(model);

                await _dbContext.AddAsync(entity);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public async Task SaveAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (System.Exception e)
            {

                throw e;
            }
        }

        public GenericRepository(EasyJamCoreDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        private readonly EasyJamCoreDbContext _dbContext;
        private readonly IMapper _mapper;
    }
}
