using DAM.Core.GraphQL.Schemas;
using DAM.Core.Messages;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository
{
    public abstract class DataRepository<TModel> : IDataRepository<TModel> where TModel : MutableModel, new()
    {
        public abstract Task<TModel> CreateAsync(TModel entity);
        public abstract Task<bool> DeleteAsync(Guid id);
        public abstract IDataResult ExecuteCommand(IDataCommand command);
        public abstract Task<TModel> GetByIdAsync(Guid id);
        public abstract Task<IQueryable<TModel>> GetItemsAsync();

        public async Task<TModel> SaveAsync(TModel value)
        {
            var original = await GetByIdAsync(value.Id);
            if (original != null)
            {
                original.SetMutableFields(value);
                return await UpdateAsync(original);
            }
            else
            {
                return await CreateAsync(value);
            }
        }

        public abstract Task<TModel> UpdateAsync(TModel entity);
    }
}
