using DAM.Core.GraphQL.Schemas.Attributes;
using DAM.Core.GraphQL.Schemas.Interfaces;
using DAM.Core.Messages.AssetDomain;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;
using System;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    [MessageCommand(typeof(Asset), typeof(UploadAssetFileCommand), typeof(UploadAssetFileResult), typeof(UploadAssetFileResultGraphType))]
    public class UploadAssetFileCommandGraphType : InputObjectGraphType, IDataCommandGraphType
    {
        public Guid AssetId { get; }
        public Guid FolderId { get; }
        public string FileName { get; }
        public byte[] FileData { get; set; }
    }
}
