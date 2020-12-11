using Bogus;
using DAM.Core.GraphQL.Repository;
using DAM.Core.GraphQL.Schemas.BundleDomain;
using DAM.Core.Messages;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.GraphQL.Repository.Fakes
{
    public class FakeBundleRepository : DataRepository<BundleModel>
    {
        private static ConcurrentDictionary<Guid, BundleModel> _inMemoryDb = new ConcurrentDictionary<Guid, BundleModel>();

        public FakeBundleRepository()
        {
            FakeInMemoryDb();
        }

        public override Task<BundleModel> CreateAsync(BundleModel entity)
        {
            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }

            if (_inMemoryDb.ContainsKey(entity.Id))
            {
                return UpdateAsync(entity);
            }

            _inMemoryDb.TryAdd(entity.Id, entity);

            return Task.FromResult(entity);
        }

        public override Task<IQueryable<BundleModel>> GetItemsAsync()
        {
            var result = _inMemoryDb.Values;
            return Task.FromResult(result.AsQueryable());
        }

        public override Task<BundleModel> GetByIdAsync(Guid id)
        {
            if (id != null && _inMemoryDb.ContainsKey(id))
            {
                return Task.FromResult(_inMemoryDb[id]);
            }

            return Task.FromResult<BundleModel>(null);
        }

        public override Task<BundleModel> UpdateAsync(BundleModel entity)
        {
            if (_inMemoryDb.ContainsKey(entity.Id))
            {
                if (_inMemoryDb.TryGetValue(entity.Id, out var currentModel))
                {
                    _inMemoryDb.TryUpdate(entity.Id, entity, currentModel);
                }
            }

            return Task.FromResult(entity);
        }
        public override Task<bool> DeleteAsync(Guid id)
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
                    var fake = FakeModel(Guid.Empty);
                    _inMemoryDb.TryAdd(fake.Id, fake);
                }
            }
        }

        private BundleModel FakeModel(Guid id)
        {
            return new Faker<BundleModel>("en")
                .RuleFor(x => x.Id, f => id != Guid.Empty ? id : f.Random.Guid())
                .RuleFor(x => x.BundleTitle, f => f.Commerce.ProductName())
                .RuleFor(x => x.BundleDescription, f => f.Commerce.ProductAdjective())
                .RuleFor(x => x.ThumbnailURL, f => f.Internet.Avatar())
                .RuleFor(x => x.Country, f => new System.Collections.Generic.List<string>{
                    f.Address.Country(),
                    f.Address.Country(),
                    f.Address.Country(),
                    f.Address.Country(),
                });
        }

        public override IDataResult ExecuteCommand(IDataCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
