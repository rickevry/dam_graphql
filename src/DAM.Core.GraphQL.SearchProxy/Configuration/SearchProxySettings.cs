using System.ComponentModel.DataAnnotations;

namespace DAM.Core.GraphQL.SearchProxy.Configuration
{
    public class SearchProxySettings
    {
        [Required]
        public string FindUrl { get; set; }

        [Required]
        public string QCUrl { get; set; }

        [Required]
        public string ListBundlesUrl { get; set; }

        [Required]
        public string AssetUrl { get; set; }

        [Required]
        public string CollectionUrl { get; set; }

        [Required]
        public string BundleUrl { get; set; }
    }
}
