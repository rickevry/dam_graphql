using DAM.Core.GraphQL.Schemas.AssetDomain;
using DAM.Core.GraphQL.Schemas.Attributes;
using DAM.Core.GraphQL.Schemas.Interfaces;
using DAM.Core.Messages.AssetDomain;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;
using System;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    [MessageCommand(typeof(Asset), typeof(UpdateAssetCommand), typeof(UpdateAssetResult), typeof(UpdateAssetResultGraphType))]
    public class UpdateAssetCommandGraphType : InputObjectGraphType, IDataCommandGraphType
    {
        public Guid AssetId { get; }
        public Guid FolderId { get; }
        public AssetInputGraphType Model { get; }
    }
}
