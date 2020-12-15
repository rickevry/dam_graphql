using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.TermsetDomain
{
    public class TermsetGraphType : ObjectGraphType<DAM.Core.Shared.Models.TermsetDomain.Termset>
    {
        public TermsetGraphType()
        {
            Name = "Termset_Termset";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.Title, nullable: true);
            Field(o => o.Terms, true, typeof(ListGraphType<TermGraphType>)).Resolve(context => context.Source.Terms);
        }
    }
}
