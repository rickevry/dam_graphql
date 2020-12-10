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
    [ModelName("Resolution")]
    [QueryName("Resolution")]
    public class ResolutionModel : MutableModel
    {
        private int _x;

        private int _y;

        /// <summary>
        /// Title: Mandatory
        /// Is the name that would appear online. This field will be searchable in all our channels and in external search such as Google.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the filename, No abbreviations or language codes etc
        /// Designation-Brand-Product-Name (ie. 6205 SKF Deep Groove Ball Bearing)

        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                SetField(ref _x, value);
            }
        }

        /// <summary>
        /// Title: Mandatory
        /// Is the name that would appear online. This field will be searchable in all our channels and in external search such as Google.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the filename, No abbreviations or language codes etc
        /// Designation-Brand-Product-Name (ie. 6205 SKF Deep Groove Ball Bearing)

        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                SetField(ref _y, value);
            }
        }

        public static implicit operator ResolutionModel(
            Shared.Models.AssetDomain.Resolution entity
        )

        {
            return entity != null ? FromEntity(entity) : null;
        }

        public static ResolutionModel
        FromEntity(Shared.Models.AssetDomain.Resolution entity)
        {
            return new ResolutionModel {
                Id = entity.Id,
                _x = entity.X,
                _y = entity.Y
            };
        }

        public static List<ResolutionModel>
        FromEntityList(List<Shared.Models.AssetDomain.Resolution> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ResolutionModel) entity)
                .ToList();
        }

        public static implicit operator Shared.Models.AssetDomain.Resolution(
            ResolutionModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.AssetDomain.Resolution
        ToEntity(ResolutionModel model)
        {
            return new Shared.Models.AssetDomain.Resolution {
                Id = model.Id,
                X = model._x,
                Y = model._y
            };
        }

        public static List<Shared.Models.AssetDomain.Resolution>
        ToEntityList(List<ResolutionModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.AssetDomain.Resolution) entity)
                .ToList();
        }
    }
}
