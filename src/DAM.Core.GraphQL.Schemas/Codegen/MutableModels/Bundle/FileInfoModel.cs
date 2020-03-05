//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Bundle;

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
