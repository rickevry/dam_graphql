using DAM.Core.DataModels.Base;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.GraphQL.Repository
{
    public abstract class DataRepository<TModel> where TModel : MutableModel, new()
    {
        public async Task<TModel> SaveAsync(TModel value)
        {
            var original = await GetByIdAsync(value.GetEntityId());
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

        public abstract Task<TModel> CreateAsync(TModel entity);

        public abstract Task<TModel> UpdateAsync(TModel entity);

        public abstract Task<bool> DeleteAsync(object id);

        public abstract Task<IQueryable<TModel>> GetItemsAsync();

        public abstract Task<TModel> GetByIdAsync(object id);
    }
}
