using GraphQL.Types;
using System;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    public class DownloadAssetFileResultGraphType : ObjectGraphType
    {
        public Guid AssetId { get; set; }
        public Guid SnapshotId { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
