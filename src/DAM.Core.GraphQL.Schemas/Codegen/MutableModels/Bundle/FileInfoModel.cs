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

        public static implicit operator Shared.Models.BundleDomain.FileInfo(
            FileInfoModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.BundleDomain.FileInfo
        ToEntity(FileInfoModel model)
        {
            return new Shared.Models.BundleDomain.FileInfo { Id = model.Id };
        }

        public static List<Shared.Models.BundleDomain.FileInfo>
        ToEntityList(List<FileInfoModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.BundleDomain.FileInfo) entity)
                .ToList();
        }
    }
}
