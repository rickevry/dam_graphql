using DAM.Core.GraphQL.Schemas.Attributes;
using DAM.Core.GraphQL.Schemas.Interfaces;
using DAM.Core.Messages.AssetDomain;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;
using System;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    [MessageCommand(typeof(Asset), typeof(CheckinAssetCommand), typeof(CheckinAssetResult), typeof(CheckinAssetResultGraphType))]
    public class CheckinAssetCommandGraphType : InputObjectGraphType, IDataCommandGraphType
    {
        public Guid EntityId { get; set; }
        public string Comment { get; set; }
        public string CheckinType { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        public CheckinAssetCommandGraphType()
        {
        }
    }
}
