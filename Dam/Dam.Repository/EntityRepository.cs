using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dam.Repository
{
    public abstract class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : MutableEntity, new()
    {
        public async Task<IQueryable<TEntity>> SearchAsync(SearchEntityArguments args)
        {
            if (!args.HasAnyParam)
            {
                return await GetEntitiesAsync();
            }

            if (args.HasSearchByIdParam)
            {
                return new List<TEntity> { await GetEntityByIdAsync(args.Id) }.AsQueryable();
            }

            return null;
        }

        public async Task<TEntity> SaveAsync(TEntity value)
        {
            var original = await GetEntityByIdAsync(value.GetEntityId());
            if (original != null)
            {
                original.SetMutableFields(value);
                return await UpdateAsync(original);
            }
            else
            {
                return await CreateAsync(value);
            }
        }

        public abstract Task<TEntity> CreateAsync(TEntity entity);

        public abstract Task<TEntity> UpdateAsync(TEntity entity);

        public abstract Task<IQueryable<TEntity>> GetEntitiesAsync();

        public abstract Task<TEntity> GetEntityByIdAsync(object id);
    }
}
