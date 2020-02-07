using Bogus;
using Dam.Repository;
using Dam.Schemas.Entities.Bundle;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dam.EntityAdapter.Fakes
{
    public class BundleRepositoryAdapter : EntityRepository<BundleEntity>
    {
        private static ConcurrentDictionary<object, BundleEntity> _inMemoryDb = new ConcurrentDictionary<object, BundleEntity>();

        public BundleRepositoryAdapter()
        {
            FakeInMemoryDb();
        }

        public override Task<BundleEntity> CreateAsync(BundleEntity entity)
        {
            if (string.IsNullOrWhiteSpace(entity.BundleId))
            {
                entity.BundleId = Guid.NewGuid().ToString();
            }

            if (_inMemoryDb.ContainsKey(entity.BundleId))
            {
                return UpdateAsync(entity);
            }

            _inMemoryDb.TryAdd(entity.BundleId, entity);

            return Task.FromResult(entity);
        }

        public override Task<IQueryable<BundleEntity>> GetEntitiesAsync()
        {
            var result = _inMemoryDb.Values;
            return Task.FromResult(result.AsQueryable());
        }

        public override Task<BundleEntity> GetEntityByIdAsync(object id)
        {
            if (id != null && _inMemoryDb.ContainsKey(id))
            {
                return Task.FromResult(_inMemoryDb[id]);
            }

            return Task.FromResult<BundleEntity>(null);
        }

        public override Task<BundleEntity> UpdateAsync(BundleEntity entity)
        {
            if (_inMemoryDb.ContainsKey(entity.BundleId))
            {
                while (_inMemoryDb.TryGetValue(entity.BundleId, out var currentEntity))
                {
                    if (_inMemoryDb.TryUpdate(entity.BundleId, entity, currentEntity))
                    {
                        break;
                    }
                }
            }

            return Task.FromResult(entity);
        }

        private void FakeInMemoryDb()
        {
            if (!_inMemoryDb.Any())
            {
                for (var i = 20; i > 0; i--)
                {
                    var fake = FakeEntity();
                    _inMemoryDb.TryAdd(fake.BundleId, fake);
                }
            }
        }

        private BundleEntity FakeEntity(object id = null)
        {
            return new Faker<BundleEntity>("en")
                .RuleFor(x => x.BundleId, f => id != null ? id.ToString() : f.Random.Guid().ToString())
                .RuleFor(x => x.BundleTitle, f => f.Commerce.ProductName())
                .RuleFor(x => x.BundleDescription, f => f.Commerce.ProductAdjective())
                .RuleFor(x => x.Icon, f => f.Internet.Avatar())
                .RuleFor(x => x.Country, f => f.Address.Country())
                .RuleFor(x => x.Version, f => f.Random.ArrayElement<VersionEntity>(
                    new VersionEntity[]
                    {
                        null,
                        new VersionEntity
                        {
                            Major = f.Random.Int(0, 10),
                            Minor = f.Random.Int(0, 100),
                        }
                    }));
        }
    }
}
