namespace EasyJamCore.DAL.Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EasyJamCore.DAL.Entities;

    public interface IGenericRepository<TModel, TEntity>
        where TEntity : class, IEntity
    {
        Task<TModel> GetById(int id);

        IEnumerable<TModel> GetAll();

        Task Add(TModel model);

        void Delete(TModel model);

        void Update(TModel model);

        void SaveChanges();
    }
}
