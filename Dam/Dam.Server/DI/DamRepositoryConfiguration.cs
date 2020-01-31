using Dam.EntityAdapter.Fakes;
using Dam.Repository;
using Dam.Schemas.Entities.Bundle;
using Microsoft.Extensions.DependencyInjection;

namespace Dam.Server
{
    public static class DamRepositoryConfiguration
    {
        public static IServiceCollection AddDamEntityRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEntityRepository<BundleEntity>, BundleRepositoryAdapter>();
            services.AddTransient<IEntityRepositoryProvider, EntityRepositoryProvider>();

            return services;
        }
    }
}
