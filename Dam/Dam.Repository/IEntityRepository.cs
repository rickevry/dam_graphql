using System;
using System.Linq;
using System.Threading.Tasks;

namespace Dam.Repository
{
    public interface IEntityRepository<TEntity> where TEntity : new()
    {
        Task<IQueryable<TEntity>> SearchAsync(SearchEntityArguments args);

        Task<TEntity> Save(TEntity entity);
    }
}
