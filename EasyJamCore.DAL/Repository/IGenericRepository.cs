using EasyJamCore.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyJamCore.DAL.Repository
{
    public interface IGenericRepository<TModel, TEntity>
        where TEntity : class, IEntity
    {
        TModel GetById(int id);
        IEnumerable<TModel> GetAll();
        Task Add(TModel model);
        void Delete(TModel model);
        void Update(TModel model);
        void SaveChanges();
    }
}
