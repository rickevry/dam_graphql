using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.FolderDomain
{
    public class FolderMutableGraphType : ObjectGraphType<FolderModel>
    {
        public FolderMutableGraphType()
        {
            Name = "FolderMutable_Folder";

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
