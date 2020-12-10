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
    [ModelName("Tridion")]
    [QueryName("tridion")]
    public class TridionModel : MutableModel
    {
        private List<string> _sites;

        /// <summary>
        /// (x,y,z)
        /// </summary>
        public List<string> Sites
        {
            get
            {
                return _sites;
            }
            set
            {
                SetField(ref _sites, value);
            }
        }

        public static implicit operator TridionModel(
            Shared.Models.AssetDomain.Tridion entity
        )

        {
            return entity != null ? FromEntity(entity) : null;
        }

        public static TridionModel
        FromEntity(Shared.Models.AssetDomain.Tridion entity)
        {
            return new TridionModel { Id = entity.Id, _sites = entity.Sites };
        }

        public static List<TridionModel>
        FromEntityList(List<Shared.Models.AssetDomain.Tridion> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (TridionModel) entity).ToList();
        }

        public static implicit operator Shared.Models.AssetDomain.Tridion(
            TridionModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.AssetDomain.Tridion
        ToEntity(TridionModel model)
        {
            return new Shared.Models.AssetDomain.Tridion {
                Id = model.Id,
                Sites = model._sites
            };
        }

        public static List<Shared.Models.AssetDomain.Tridion>
        ToEntityList(List<TridionModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.AssetDomain.Tridion) entity)
                .ToList();
        }
    }
}
