//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:32.160Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAM.Core.DataModels.Base;

namespace DAM.Core.DataModels.Asset
{
    [ModelName("Rights")]
    [QueryName("Rights")]
    public class RightsModel : MutableModel
    {
        private string _securityClass;

        private bool _rightsManaged;

        private string _rightsManagedDescription;

        private bool _tridionRestricted;

        /// <summary>
        /// Security Class
        /// </summary>
        public string SecurityClass
        {
            get
            {
                return _securityClass;
            }
            set
            {
                SetField(ref _securityClass, value);
            }
        }

        /// <summary>
        ///  Rights managed : This field is required by SKF legal and limits the usage and distribution of your asset.
        /// SKF_internal
        /// SKF_open
        /// Rights_managed
        /// Restricted_content_on_skf_com
        /// Publish_enabled_for_skf_com
        /// </summary>
        public bool RightsManaged
        {
            get
            {
                return _rightsManaged;
            }
            set
            {
                SetField(ref _rightsManaged, value);
            }
        }

        /// <summary>
        /// Rights managed description : This field is required by SKF legal and limits the usage and distribution of your asset.
        /// SKF_internal
        /// SKF_open
        /// Rights_managed
        /// Restricted_content_on_skf_com
        /// Publish_enabled_for_skf_com
        /// </summary>
        public string RightsManagedDescription
        {
            get
            {
                return _rightsManagedDescription;
            }
            set
            {
                SetField(ref _rightsManagedDescription, value);
            }
        }

        /// <summary>
        /// Tridion restricted (keep or remove?): This field is required by SKF legal and limits the usage and distribution of your asset.
        /// SKF_internal
        /// SKF_open
        /// Rights_managed
        /// Restricted_content_on_skf_com
        /// Publish_enabled_for_skf_com
        /// </summary>
        public bool TridionRestricted
        {
            get
            {
                return _tridionRestricted;
            }
            set
            {
                SetField(ref _tridionRestricted, value);
            }
        }
    }
}
