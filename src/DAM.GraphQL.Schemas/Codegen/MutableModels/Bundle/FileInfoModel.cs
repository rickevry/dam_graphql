//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:24.925Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Bundle
{
    [ModelName("FileInfo")]
    [QueryName("FileInfo")]
    public class FileInfoModel : MutableModel
    {
        public static implicit operator FileInfoModel(
            Services.Models.Bundle.FileInfo entity
        )

        {
            return FromEntity(entity);
        }

        public static FileInfoModel
        FromEntity(Services.Models.Bundle.FileInfo entity)
        {
            return new FileInfoModel { Id = entity.Id };
        }

        public static List<FileInfoModel>
        FromEntityList(List<Services.Models.Bundle.FileInfo> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (FileInfoModel) entity).ToList();
        }
    }
}
