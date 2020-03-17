using DAM.Core.GraphQL.Schemas.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    public class GetAssetByIdResultGraphType : ObjectGraphType
    {
        public AssetGraphType AssetModel { get; set; }

        public bool IsSuccessful { get; set; }
    }
}
