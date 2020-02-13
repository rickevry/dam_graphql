//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:31.857Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAM.Core.DataModels.Base;

namespace DAM.Core.DataModels.Bundle
{
    [ModelName("Bundle")]
    [QueryName("bundles")]
    public class BundleModel : MutableModel
    {
        private string _bundleId;

        private VersionModel _version;

        private string _bundleTitle;

        private string _bundleDescription;

        private FileInfoModel _invoice;

        private List<string> _languagesInAssets;

        private string _icon;

        private List<FileInfoModel> _attachments;

        private string _country;

        private string _collections;

        /// <summary>
        /// description missing
        /// </summary>
        [Key]
        public string BundleId
        {
            get
            {
                return _bundleId;
            }
            set
            {
                _id = value;
                SetField(ref _bundleId, value);
            }
        }

        /// <summary>
        /// Version of the bundle
        /// </summary>
        public VersionModel Version
        {
            get
            {
                return _version;
            }
            set
            {
                SetField(ref _version, value);
            }
        }

        public string BundleTitle
        {
            get
            {
                return _bundleTitle;
            }
            set
            {
                SetField(ref _bundleTitle, value);
            }
        }

        public string BundleDescription
        {
            get
            {
                return _bundleDescription;
            }
            set
            {
                SetField(ref _bundleDescription, value);
            }
        }

        public FileInfoModel Invoice
        {
            get
            {
                return _invoice;
            }
            set
            {
                SetField(ref _invoice, value);
            }
        }

        public List<string> LanguagesInAssets
        {
            get
            {
                return _languagesInAssets;
            }
            set
            {
                SetField(ref _languagesInAssets, value);
            }
        }

        /// <summary>
        /// hello
        /// world
        /// </summary>
        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                SetField(ref _icon, value);
            }
        }

        public List<FileInfoModel> Attachments
        {
            get
            {
                return _attachments;
            }
            set
            {
                SetField(ref _attachments, value);
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                SetField(ref _country, value);
            }
        }

        public string Collections
        {
            get
            {
                return _collections;
            }
            set
            {
                SetField(ref _collections, value);
            }
        }
    }
}
