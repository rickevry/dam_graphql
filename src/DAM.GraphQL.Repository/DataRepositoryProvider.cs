using DAM.GraphQL.Schemas;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAM.GraphQL.Repository
{
    public class DataRepositoryProvider
    {
        private readonly IServiceProvider _provider;

        public DataRepositoryProvider(IServiceProvider provider)
        {
            _provider = provider;
        }

        public DataRepository<TModel> GetRepository<TModel>() where TModel : MutableModel, new()
        {
            var repository = _provider.GetRequiredService<DataRepository<TModel>>();
            return repository;
        }
    }
}
