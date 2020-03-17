//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.BundleDomain;

namespace DAM.Core.GraphQL.Schemas.BundleDomain
{
    [ModelName("FileInfo")]
    [QueryName("FileInfo")]
    public class FileInfoModel : MutableModel
    {
        public static implicit operator FileInfoModel(
            Shared.Models.BundleDomain.FileInfo entity
        )

        {
            return FromEntity(entity);
        }

        public static FileInfoModel
        FromEntity(Shared.Models.BundleDomain.FileInfo entity)
        {
            return new FileInfoModel { Id = entity.Id };
        }

        public static List<FileInfoModel>
        FromEntityList(List<Shared.Models.BundleDomain.FileInfo> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (FileInfoModel) entity).ToList();
        }
    }
}
