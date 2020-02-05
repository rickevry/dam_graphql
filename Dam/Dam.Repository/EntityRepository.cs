using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dam.Repository
{
    public abstract class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : DamEntity, new()
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

        public async Task<TEntity> Save(TEntity value)
        {
            var id = GetEntityId(value);

            if (id.HasValue)
            {
                var original = await GetEntityByIdAsync(id.Value);
                if (original != null)
                {
                    return await Update(SetMutableFields(original, value));
                }
                else
                {
                    return await Create(value);
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(id));
            }
        }

        protected Guid? GetEntityId(TEntity entity)
        {
            // TODO: get id from property with KeyAttribute
            return Guid.NewGuid();
        }

        protected TEntity SetMutableFields(TEntity original, TEntity mutated)
        {
            if (original == null)
            {
                return mutated;
            }

            var properties = typeof(TEntity).GetProperties();
            if (properties != null && properties.Any())
            {
                foreach (var property in properties)
                {
                    if (mutated.IsPropertyMutated(property.Name))
                    {
                        // TODO: Recursive for add/modify complex object property
                        var modifiedValue = property.GetValue(mutated);
                        property.SetValue(original, modifiedValue);
                    }
                }
            }

            return original;
        }

        public abstract Task<TEntity> Create(TEntity entity);

        public abstract Task<TEntity> Update(TEntity entity);

        public abstract Task<IQueryable<TEntity>> GetEntitiesAsync();

        public abstract Task<TEntity> GetEntityByIdAsync(Guid id);
    }
}
