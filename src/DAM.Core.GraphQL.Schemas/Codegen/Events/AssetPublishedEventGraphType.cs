using DAM.Core.GraphQL.Schemas.AssetDomain;
using DAM.Core.GraphQL.Schemas.Interfaces;
using DAM.Core.Messages.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Codegen.Events
{
    public class AssetPublishedEventGraphType : ObjectGraphType<AssetPublishedEvent>, IDataEventGraphType
    {
        public AssetPublishedEventGraphType()
        {
            Field(o => o.AssetModel, true, typeof(AssetGraphType));
        }
    }
}
