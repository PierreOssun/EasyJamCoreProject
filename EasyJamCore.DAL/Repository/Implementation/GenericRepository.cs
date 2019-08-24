using AutoMapper;
using EasyJamCore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyJamCore.DAL.Repository.Implementation
{
    public class GenericRepository<TModel,TEntity> : IGenericRepository<TModel, TEntity>
        where TEntity  : class, IEntity
        where TModel : class
    {
        public async Task<TModel> GetById(int id)
        {
            try
            {
                var entity = await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.ID == id);
                var result = _mapper.Map<TModel>(entity);
                return result;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

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

        public void Update(TModel model)
        {
            try
            {
                var entity = _mapper.Map<TModel, TEntity>(model);

                _dbContext.Update(entity);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public void Delete(TModel model)
        {
            try
            {
                var entity = _mapper.Map<TModel, TEntity>(model);

                _dbContext.Remove(entity);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public void SaveChanges()
        {
            try
            {
                 _dbContext.SaveChanges();
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
