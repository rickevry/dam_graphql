//
//  This file was automatically generated and should not be edited.
//  2020-02-05T21:54:55.730Z
//
using System;
using System.Collections.Generic;
using Dam.Repository;
using Dam.Schemas.Attributes;

namespace Dam.Schemas.Entities.Bundle
{
    [QueryName("Attachment")]
    public class AttachmentEntity : DamEntity
    {
#region Private fields

        private string _downloadUrl;

        private DateTime _uploadDateTime;


#endregion


        public string DownloadUrl
        {
            get
            {
                return _downloadUrl;
            }
            set
            {
                SetField(ref _downloadUrl, value);
            }
        }

        public DateTime UploadDateTime
        {
            get
            {
                return _uploadDateTime;
            }
            set
            {
                SetField(ref _uploadDateTime, value);
            }
        }
    }
}
