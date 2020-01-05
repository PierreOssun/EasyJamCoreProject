namespace EasyJamCore.DAL.Repository.Implementation
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using EasyJamCore.DAL.Entities;
    using Microsoft.EntityFrameworkCore;

    public class GenericRepository<TModel, TEntity> : IGenericRepository<TModel, TEntity>
        where TEntity : class, IEntity
        where TModel : class
    {
        private readonly EasyJamCoreDbContext dbContext;
        private readonly IMapper mapper;

        public GenericRepository(EasyJamCoreDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<TModel> GetById(int id)
        {
            try
            {
                var entity = await dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.ID == id).ConfigureAwait(false);
                var result = mapper.Map<TModel>(entity);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public IEnumerable<TModel> GetAll()
        {
            IQueryable<TEntity> entities = dbContext.Set<TEntity>().AsNoTracking();
            return mapper.Map<IEnumerable<TModel>>(entities).AsEnumerable();
        }

        public async Task Add(TModel model)
        {
            try
            {
                var entity = mapper.Map<TModel, TEntity>(model);

                await dbContext.AddAsync(entity).ConfigureAwait(true);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Update(TModel model)
        {
            try
            {
                var entity = mapper.Map<TModel, TEntity>(model);

                dbContext.Update(entity);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Delete(TModel model)
        {
            try
            {
                var entity = mapper.Map<TModel, TEntity>(model);

                dbContext.Remove(entity);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void SaveChanges()
        {
            try
            {
                 dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
