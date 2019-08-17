using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyJamCore.DAL.Repository
{
    public interface IGenericRepository<TModel, TEntity>
    {
        IEnumerable<TModel> GetAll();
        Task Add(TModel model);
        Task SaveAsync();
    }
}
