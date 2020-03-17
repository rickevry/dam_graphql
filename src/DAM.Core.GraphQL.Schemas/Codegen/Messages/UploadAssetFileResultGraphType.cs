using GraphQL.Types;
using System;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    public class UploadAssetFileResultGraphType : ObjectGraphType
    {
        public Guid AssetId { get; set; }
        public Guid FolderId { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
