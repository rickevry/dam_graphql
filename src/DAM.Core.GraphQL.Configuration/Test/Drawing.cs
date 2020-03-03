using GraphQL.Types;

namespace DAM.Core.GraphQL.Configuration
{
    public class DrawingModel
    {
        public string Type { get => "drawing"; }
        public string Title { get; set; }
        public string Info { get; set; }
    }

    public class DrawingGraphType : ObjectGraphType<DrawingModel>
    {
        public DrawingGraphType()
        {
            Field(o => o.Type);
            Field(o => o.Title);
            Field(o => o.Info);

            Interface<SearchItemInterface>();
        }
    }
}
