using Microsoft.Extensions.DependencyInjection;
using System;

namespace Dam.Repository
{
    public class EntityRepositoryProvider : IEntityRepositoryProvider
    {
        private readonly IServiceProvider _provider;

        public EntityRepositoryProvider(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IEntityRepository<TEntity> GetRepository<TEntity>() where TEntity : new()
        {
            var repository = _provider.GetRequiredService<IEntityRepository<TEntity>>();
            return repository;
        }
    }
}
