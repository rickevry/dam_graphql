//
//  This file was automatically generated and should not be edited.
//  2020-01-31T20:54:44.802Z
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
            Field(o => o.DownloadUrl);
            Field(o => o.UploadDateTime);
        }
    }
}
