//
//  This file was automatically generated and should not be edited.
//  2020-02-07T10:08:59.174Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dam.Repository;
using Dam.Repository.Attributes;
using Dam.Schemas.Attributes;

namespace Dam.Schemas.Entities.Bundle
{
    [EntityName("Attachment")]
    [QueryName("attachments")]
    public class AttachmentEntity : MutableEntity
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
