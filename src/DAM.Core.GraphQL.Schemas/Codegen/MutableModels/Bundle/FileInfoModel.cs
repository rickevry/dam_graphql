//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:52.432Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Bundle
{
    [ModelName("FileInfo")]
    [QueryName("FileInfo")]
    public class FileInfoModel : MutableModel
    {
        public static implicit operator FileInfoModel(
            Shared.Models.Bundle.FileInfo entity
        )

        {
            return FromEntity(entity);
        }

        public static FileInfoModel
        FromEntity(Shared.Models.Bundle.FileInfo entity)
        {
            return new FileInfoModel { Id = entity.Id };
        }

        public static List<FileInfoModel>
        FromEntityList(List<Shared.Models.Bundle.FileInfo> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (FileInfoModel) entity).ToList();
        }
    }
}
