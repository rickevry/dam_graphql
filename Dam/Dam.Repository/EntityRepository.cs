using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dam.Repository
{
    public abstract class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : new()
    {
        public async Task<IQueryable<TEntity>> SearchAsync(SearchEntityArguments args)
        {
            if (!args.HasAnyParam)
            {
                return await GetEntitiesAsync();
            }

            if (args.HasSearchByIdParam)
            {
                return new List<TEntity> { await GetEntityByIdAsync(args.Id.Value) }.AsQueryable();
            }

            return null;
        }

        public abstract Task<IQueryable<TEntity>> GetEntitiesAsync();

        public abstract Task<TEntity> GetEntityByIdAsync(Guid id);
    }
}
