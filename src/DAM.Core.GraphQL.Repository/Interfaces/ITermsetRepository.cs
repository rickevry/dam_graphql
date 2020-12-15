using DAM.Core.GraphQL.Schemas.TermsetDomain;
using DAM.Core.Shared.Models.TermsetDomain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository
{

    public interface ITermsetRepository : IDataRepository<TermsetModel>
    {
        Task<List<Termset>> GetListByEidAsync(string eid);

        Task<Termset> GetFoldersByWorkspace(string wid);

    }
}
