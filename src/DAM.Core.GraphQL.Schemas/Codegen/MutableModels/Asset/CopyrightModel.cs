//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.AssetDomain;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    [ModelName("Copyright")]
    [QueryName("Copyright")]
    public class CopyrightModel : MutableModel
    {
        private string _assetSource;

        private string _copyrightOwner;

        private string _copyrightDescription;

        private DateTime _copyrightExpiryDate;

        /// <summary>
        /// Asset source : Explains the soruce from which your asset was fist produced
        /// SKF_internally_produced
        /// Customer_produced
        /// SKF_contracted_supplier
        /// Shutterstock_using_SKF_Corporate_License
        /// </summary>
        public string AssetSource
        {
            get
            {
                return _assetSource;
            }
            set
            {
                SetField(ref _assetSource, value);
            }
        }

        public string CopyrightOwner
        {
            get
            {
                return _copyrightOwner;
            }
            set
            {
                SetField(ref _copyrightOwner, value);
            }
        }

        public string CopyrightDescription
        {
            get
            {
                return _copyrightDescription;
            }
            set
            {
                SetField(ref _copyrightDescription, value);
            }
        }

        public DateTime CopyrightExpiryDate
        {
            get
            {
                return _copyrightExpiryDate;
            }
            set
            {
                SetField(ref _copyrightExpiryDate, value);
            }
        }

        public static implicit operator CopyrightModel(
            Shared.Models.AssetDomain.Copyright entity
        )

        {
            return FromEntity(entity);
        }

        public static CopyrightModel
        FromEntity(Shared.Models.AssetDomain.Copyright entity)
        {
            return new CopyrightModel {
                Id = entity.Id,
                _assetSource = entity.AssetSource,
                _copyrightOwner = entity.CopyrightOwner,
                _copyrightDescription = entity.CopyrightDescription,
                _copyrightExpiryDate = entity.CopyrightExpiryDate
            };
        }

        public static List<CopyrightModel>
        FromEntityList(List<Shared.Models.AssetDomain.Copyright> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CopyrightModel) entity)
                .ToList();
        }

        public static implicit operator Shared.Models.AssetDomain.Copyright(
            CopyrightModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.AssetDomain.Copyright
        ToEntity(CopyrightModel model)
        {
            return new Shared.Models.AssetDomain.Copyright {
                Id = model.Id,
                AssetSource = model._assetSource,
                CopyrightOwner = model._copyrightOwner,
                CopyrightDescription = model._copyrightDescription,
                CopyrightExpiryDate = model._copyrightExpiryDate
            };
        }

        public static List<Shared.Models.AssetDomain.Copyright>
        ToEntityList(List<CopyrightModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.AssetDomain.Copyright) entity)
                .ToList();
        }
    }
}
