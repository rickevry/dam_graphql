using DAM.Core.GraphQL.Schemas.Attributes;
using DAM.Core.GraphQL.Schemas.Interfaces;
using DAM.Core.Messages.AssetDomain;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;
using System;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    [MessageCommand(typeof(Asset), typeof(GetAssetByIdCommand), typeof(GetAssetByIdResult), typeof(GetAssetByIdResultGraphType))]
    public class GetAssetByIdCommandGraphType : InputObjectGraphType, IDataCommandGraphType
    {
        public Guid AssetId { get; set; }
    }
}
