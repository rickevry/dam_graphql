//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:23.200Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Asset;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("Version")]
    [QueryName("versions")]
    public class VersionModel : MutableModel
    {
        private int _major;

        private int _minor;

        private bool _current;

        private string _snapshot;

        /// <summary>
        /// description missing
        /// </summary>
        public int Major
        {
            get
            {
                return _major;
            }
            set
            {
                SetField(ref _major, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public int Minor
        {
            get
            {
                return _minor;
            }
            set
            {
                SetField(ref _minor, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public bool Current
        {
            get
            {
                return _current;
            }
            set
            {
                SetField(ref _current, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public string Snapshot
        {
            get
            {
                return _snapshot;
            }
            set
            {
                SetField(ref _snapshot, value);
            }
        }

        public static implicit operator VersionModel(
            Shared.Models.Asset.Version entity
        )

        {
            return FromEntity(entity);
        }

        public static VersionModel
        FromEntity(Shared.Models.Asset.Version entity)
        {
            return new VersionModel {
                Id = entity.Id,
                _major = entity.Major,
                _minor = entity.Minor,
                _current = entity.Current,
                _snapshot = entity.Snapshot
            };
        }

        public static List<VersionModel>
        FromEntityList(List<Shared.Models.Asset.Version> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (VersionModel) entity).ToList();
        }
    }
}
