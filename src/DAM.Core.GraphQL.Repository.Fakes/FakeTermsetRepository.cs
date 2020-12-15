using DAM.Core.GraphQL.Schemas.TermsetDomain;
using DAM.Core.Messages;
using DAM.Core.Shared.Models.TermsetDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository.Fakes
{
    public class FakeTermsetRepository : DataRepository<TermsetModel>, ITermsetRepository
    {
        public override Task<TermsetModel> CreateAsync(TermsetModel entity)
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

        public override Task<TermsetModel> GetByIdAsync(Guid id)
        {
            try
            {

                var item = new TermsetModel()
                {
                    Eid = "123",
                    Title = "floff",
                    Terms = new List<TermModel>()
                {
                    new Term () { Id = "111", Title = "kjkj" },
                    new Term () { Id = "111", Title = "kjkj" },
                    new Term () { Id = "111", Title = "kjkj" },
                    new Term () { Id = "111", Title = "kjkj" },
                }
                };
 

                return Task.FromResult(item);
            }
            catch
            {
                return null;
            }
        }

        public Task<List<Termset>> GetListByEidAsync(string eid)
        {
            try
            {

                var result = new List<Termset>();
                var item = new Termset()
                {
                    Eid = "123",
                    Title = "floff",
                    Terms = new List<Term>()
                {
                    new Term () { Id = "111", Title = "kjkj" },
                    new Term () { Id = "111", Title = "kjkj" },
                    new Term () { Id = "111", Title = "kjkj" },
                    new Term () { Id = "111", Title = "kjkj" },
                }
                };
                result.Add(item);

                return Task.FromResult(result);
            }
            catch
            {
                return null;
            }
        }

        public override Task<IQueryable<TermsetModel>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<TermsetModel> UpdateAsync(TermsetModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
