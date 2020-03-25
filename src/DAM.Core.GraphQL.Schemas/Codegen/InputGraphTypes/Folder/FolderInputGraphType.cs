using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.FolderDomain
{
    public class FolderInputGraphType : InputObjectGraphType<FolderModel>
    {
        public FolderInputGraphType()
        {
            Name = "Person_Person";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
        }
    }
}
