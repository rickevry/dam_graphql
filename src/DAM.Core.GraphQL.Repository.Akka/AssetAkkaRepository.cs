using DAM.Core.GraphQL.Schemas.Asset;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository.Akka
{
    public class AssetActorRepository : DataRepository<AssetModel>
    {
        public override Task<AssetModel> CreateAsync(AssetModel entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<AssetModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<IQueryable<AssetModel>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<AssetModel> UpdateAsync(AssetModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
