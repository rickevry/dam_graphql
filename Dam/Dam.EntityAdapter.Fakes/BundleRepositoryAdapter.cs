using Bogus;
using Dam.Repository;
using Dam.Schemas.Entities.Bundle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dam.EntityAdapter.Fakes
{
    public class BundleRepositoryAdapter : EntityRepository<BundleEntity>
    {
        public override Task<IQueryable<BundleEntity>> GetEntitiesAsync()
        {
            var result = new List<BundleEntity>();

            for (var i = 20; i > 0; i--)
            {
                result.Add(FakeEntity());
            }

            return Task.FromResult(result.AsQueryable());
        }

        public override Task<BundleEntity> GetEntityByIdAsync(Guid id)
        {
            return Task.FromResult(FakeEntity(id));
        }

        private BundleEntity FakeEntity(Guid? id = null)
        {
            return new Faker<BundleEntity>("en")
                .RuleFor(x => x.BundleId, f => (id.HasValue ? id.Value : f.Random.Guid()).ToString())
                .RuleFor(x => x.BundleTitle, f => f.Commerce.ProductName())
                .RuleFor(x => x.BundleDescription, f => f.Commerce.ProductAdjective());
        }
    }
}
