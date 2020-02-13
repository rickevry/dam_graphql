//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:31.913Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAM.Core.DataModels.Base;

namespace DAM.Core.DataModels.Bundle
{
    [ModelName("FileInfo")]
    [QueryName("FileInfo")]
    public class FileInfoModel : MutableModel
    {
        private string _downloadUrl;

        private DateTime _uploadDateTime;

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
