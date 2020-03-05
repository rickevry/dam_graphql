using System.ComponentModel.DataAnnotations;

namespace DAM.Core.GraphQL.SearchProxy.Configuration
{
    public class SearchProxySettings
    {
        [Required]
        public string FindUrl { get; set; }

        [Required]
        public string QCUrl { get; set; }
    }
}
