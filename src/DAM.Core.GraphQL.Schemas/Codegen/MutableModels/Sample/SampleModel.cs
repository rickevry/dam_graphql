//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.SampleDomain;

namespace DAM.Core.GraphQL.Schemas.SampleDomain
{
    [ModelName("Asset")]
    [QueryName("assets")]
    public class SampleModel : MutableModel
    {
        private DateTime _createdDate;

        private Guid _createdBy;

        private DateTime _modifiedDate;

        private Guid _modifiedBy;

        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                SetField(ref _createdDate, value);
            }
        }

        public Guid CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                SetField(ref _createdBy, value);
            }
        }

        public DateTime ModifiedDate
        {
            get
            {
                return _modifiedDate;
            }
            set
            {
                SetField(ref _modifiedDate, value);
            }
        }

        public Guid ModifiedBy
        {
            get
            {
                return _modifiedBy;
            }
            set
            {
                SetField(ref _modifiedBy, value);
            }
        }

        public static implicit operator SampleModel(
            Shared.Models.SampleDomain.Sample entity
        )

        {
            return FromEntity(entity);
        }

        public static SampleModel
        FromEntity(Shared.Models.SampleDomain.Sample entity)
        {
            return new SampleModel {
                Id = entity.Id,
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _modifiedDate = entity.ModifiedDate,
                _modifiedBy = entity.ModifiedBy
            };
        }

        public static List<SampleModel>
        FromEntityList(List<Shared.Models.SampleDomain.Sample> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (SampleModel) entity).ToList();
        }

        public static implicit operator Shared.Models.SampleDomain.Sample(
            SampleModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.SampleDomain.Sample
        ToEntity(SampleModel model)
        {
            return new Shared.Models.SampleDomain.Sample {
                Id = model.Id,
                CreatedDate = model._createdDate,
                CreatedBy = model._createdBy,
                ModifiedDate = model._modifiedDate,
                ModifiedBy = model._modifiedBy
            };
        }

        public static List<Shared.Models.SampleDomain.Sample>
        ToEntityList(List<SampleModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.SampleDomain.Sample) entity)
                .ToList();
        }
    }
}
