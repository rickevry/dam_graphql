//
//  This file was automatically generated and should not be edited.
//  2020-02-07T10:08:59.184Z
//
using System;
using System.Collections.Generic;
using Dam.Schemas.Entities.Bundle;
using GraphQL.Types;

namespace Dam.Schemas.GraphTypes.Bundle
{
    public class AttachmentGraphType : ObjectGraphType<AttachmentEntity>
    {
        public AttachmentGraphType()
        {
            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.DownloadUrl, nullable: true);
            Field(o => o.UploadDateTime, nullable: true);
        }
    }
}
