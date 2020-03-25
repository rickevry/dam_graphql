using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.FolderDomain
{
    public class FolderGraphType : ObjectGraphType<DAM.Core.Shared.Models.FolderDomain.Folder>
    {
        public FolderGraphType()
        {
            Name = "Folder_Folder";

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
