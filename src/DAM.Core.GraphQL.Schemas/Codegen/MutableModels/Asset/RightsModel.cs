//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.736Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("Rights")]
    [QueryName("Rights")]
    public class RightsModel : MutableModel
    {
        private string _securityClass;

        private bool _rightsManaged;

        private bool _tridionRestricted;

        private string _rightsManagedDescription;

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

        public static implicit operator RightsModel(
            Shared.Models.Asset.Rights entity
        )

        {
            return FromEntity(entity);
        }

        public static RightsModel FromEntity(Shared.Models.Asset.Rights entity)
        {
            return new RightsModel {
                Id = entity.Id,
                _securityClass = entity.SecurityClass,
                _rightsManaged = entity.RightsManaged,
                _tridionRestricted = entity.TridionRestricted,
                _rightsManagedDescription = entity.RightsManagedDescription
            };
        }

        public static List<RightsModel>
        FromEntityList(List<Shared.Models.Asset.Rights> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (RightsModel) entity).ToList();
        }
    }
}
