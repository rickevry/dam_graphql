//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.296Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("DocumentAttributes")]
    [QueryName("documentAttributes")]
    public class DocumentAttributesModel : MutableModel
    {
        private List<string> _documentContent;

        private long _size;

        private string _checksum;

        public List<string> DocumentContent
        {
            get
            {
                return _documentContent;
            }
            set
            {
                SetField(ref _documentContent, value);
            }
        }

        public long Size
        {
            get
            {
                return _size;
            }
            set
            {
                SetField(ref _size, value);
            }
        }

        public string Checksum
        {
            get
            {
                return _checksum;
            }
            set
            {
                SetField(ref _checksum, value);
            }
        }

        public static implicit operator DocumentAttributesModel(
            Services.Models.Asset.DocumentAttributes entity
        )

        {
            return FromEntity(entity);
        }

        public static DocumentAttributesModel
        FromEntity(Services.Models.Asset.DocumentAttributes entity)
        {
            return new DocumentAttributesModel {
                Id = entity.Id,
                _documentContent = entity.DocumentContent,
                _size = entity.Size,
                _checksum = entity.Checksum
            };
        }

        public static List<DocumentAttributesModel>
        FromEntityList(
            List<Services.Models.Asset.DocumentAttributes> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (DocumentAttributesModel) entity)
                .ToList();
        }
    }
}
