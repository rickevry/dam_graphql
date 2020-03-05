using System.Threading.Tasks;

namespace DAM.Core.GraphQL.SearchProxy.Providers
{
    public interface ISearchProvider
    {
        Task<string> Search(string queryParams, string token);
    }
}
