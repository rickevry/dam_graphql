using DAM.Core.GraphQL.Schemas;
using DAM.Core.Messages;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository
{
    public interface IDataRepository<TModel> where TModel : MutableModel, new()
    {
        IDataResult ExecuteCommand(IDataCommand command);

        Task<TModel> CreateAsync(TModel entity);

        Task<TModel> UpdateAsync(TModel entity);

        Task<bool> DeleteAsync(Guid id);

        Task<IQueryable<TModel>> GetItemsAsync();

        Task<TModel> GetByIdAsync(Guid id);
    }
}
