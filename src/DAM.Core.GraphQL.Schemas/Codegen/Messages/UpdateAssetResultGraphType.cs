using DAM.Core.GraphQL.Schemas.AssetDomain;
using GraphQL.Types;
using System;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    public class UpdateAssetResultGraphType : ObjectGraphType
    {
        public Guid AssetId { get; set; }
        public Guid FolderId { get; set; }
        public AssetGraphType Model { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
