using GraphQL.Types;

namespace DAM.Core.GraphQL.Configuration
{
    public class InvoiceModel
    {
        public string Type { get => "invoice"; }
        public string Title { get; set; }
        public string Customer { get; set; }
        public double Amount { get; set; }
    }

    public class InvoiceGraphType : ObjectGraphType<InvoiceModel>
    {
        public InvoiceGraphType()
        {
            Field(o => o.Type);
            Field(o => o.Title);
            Field(o => o.Customer);
            Field(o => o.Amount);

            Interface<SearchItemInterface>();
        }
    }
}
