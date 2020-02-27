using System.ComponentModel.DataAnnotations;

namespace DAM.Core.GraphQL.SearchProxy.Configuration
{
    public class SearchProxySettings
    {
        [Required]
        public string Url { get; set; }
    }
}
