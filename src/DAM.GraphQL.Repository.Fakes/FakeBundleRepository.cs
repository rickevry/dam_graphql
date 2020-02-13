using Bogus;
using DAM.Core.DataModels.Bundle;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.GraphQL.Repository.Fakes
{
    public class FakeBundleRepository : DataRepository<BundleModel>
    {
        private static ConcurrentDictionary<object, BundleModel> _inMemoryDb = new ConcurrentDictionary<object, BundleModel>();

        public FakeBundleRepository()
        {
            FakeInMemoryDb();
        }

        public override Task<BundleModel> CreateAsync(BundleModel entity)
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

        public override Task<IQueryable<BundleModel>> GetItemsAsync()
        {
            var result = _inMemoryDb.Values;
            return Task.FromResult(result.AsQueryable());
        }

        public override Task<BundleModel> GetByIdAsync(object id)
        {
            if (id != null && _inMemoryDb.ContainsKey(id))
            {
                return Task.FromResult(_inMemoryDb[id]);
            }

            return Task.FromResult<BundleModel>(null);
        }

        public override Task<BundleModel> UpdateAsync(BundleModel entity)
        {
            if (_inMemoryDb.ContainsKey(entity.BundleId))
            {
                if (_inMemoryDb.TryGetValue(entity.BundleId, out var currentModel))
                {
                    _inMemoryDb.TryUpdate(entity.BundleId, entity, currentModel);
                }
            }

            return Task.FromResult(entity);
        }
        public override Task<bool> DeleteAsync(object id)
        {
            if (_inMemoryDb.ContainsKey(id))
            {
                Task.FromResult(_inMemoryDb.TryRemove(id, out _));
            }

            return Task.FromResult(false);
        }

        private void FakeInMemoryDb()
        {
            if (!_inMemoryDb.Any())
            {
                for (var i = 20; i > 0; i--)
                {
                    var fake = FakeModel();
                    _inMemoryDb.TryAdd(fake.BundleId, fake);
                }
            }
        }

        private BundleModel FakeModel(object id = null)
        {
            return new Faker<BundleModel>("en")
                .RuleFor(x => x.BundleId, f => id != null ? id.ToString() : f.Random.Guid().ToString())
                .RuleFor(x => x.BundleTitle, f => f.Commerce.ProductName())
                .RuleFor(x => x.BundleDescription, f => f.Commerce.ProductAdjective())
                .RuleFor(x => x.Icon, f => f.Internet.Avatar())
                .RuleFor(x => x.Country, f => f.Address.Country())
                .RuleFor(x => x.Version, f => f.Random.ArrayElement(
                    new VersionModel[]
                    {
                        null,
                        new VersionModel
                        {
                            Major = f.Random.Int(0, 10),
                            Minor = f.Random.Int(0, 100),
                        }
                    }));
        }

    }
}
