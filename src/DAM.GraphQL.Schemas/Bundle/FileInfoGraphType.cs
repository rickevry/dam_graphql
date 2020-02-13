//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:31.916Z
//
using System;
using System.Collections.Generic;
using DAM.Core.DataModels.Bundle;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Bundle
{
    public class FileInfoGraphType : ObjectGraphType<FileInfoModel>
    {
        public FileInfoGraphType()
        {
            Name = "Bundle_FileInfo";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.DownloadUrl, nullable: true);
            Field(o => o.UploadDateTime, nullable: true);
        }
    }
}
