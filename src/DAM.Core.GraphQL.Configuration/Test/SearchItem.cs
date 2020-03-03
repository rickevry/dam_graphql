using GraphQL.Types;

namespace DAM.Core.GraphQL.Configuration
{
    public class SearchItem
    {
        public string Title { get; set; }
    }

    public class SearchItemInterface : InterfaceGraphType<SearchItem>
    {
        public SearchItemInterface()
        {
            Field(o => o.Title);
        }
    }
}
