using DAM.Core.GraphQL.Schemas.FolderDomain;
using DAM.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository.Fakes
{
    class FakeFolderRepository : DataRepository<FolderModel>
    {
        public override Task<FolderModel> CreateAsync(FolderModel entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public override IDataResult ExecuteCommand(IDataCommand command)
        {
            throw new NotImplementedException();
        }

        public override Task<FolderModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<IQueryable<FolderModel>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<FolderModel> UpdateAsync(FolderModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
