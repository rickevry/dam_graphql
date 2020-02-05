//
//  This file was automatically generated and should not be edited.
//  2020-02-05T21:54:55.634Z
//
using System;
using System.Collections.Generic;
using Dam.Repository;
using Dam.Schemas.Attributes;

namespace Dam.Schemas.Entities.Bundle
{
    [QueryName("Bundle")]
    public class BundleEntity : DamEntity
    {
#region Private fields

        private string _bundleId;

        private VersionEntity _version;

        private string _bundleTitle;

        private string _bundleDescription;

        private List<string> _languagesInAssets;

        private List<AttachmentEntity> _attachment;

        private string _icon;

        private string _country;

        private string _collections;


#endregion


        /// <summary>
        /// description missing
        /// </summary>
        public string BundleId
        {
            get
            {
                return _bundleId;
            }
            set
            {
                SetField(ref _bundleId, value);
            }
        }

        /// <summary>
        /// Version of the bundle
        /// </summary>
        public VersionEntity Version
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

        public List<AttachmentEntity> Attachment
        {
            get
            {
                return _attachment;
            }
            set
            {
                SetField(ref _attachment, value);
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
