//
//  This file was automatically generated and should not be edited.
//  2020-02-05T21:54:55.659Z
//
using System;
using System.Collections.Generic;
using Dam.Repository;
using Dam.Schemas.Attributes;

namespace Dam.Schemas.Entities.Bundle
{
    [QueryName("Version")]
    public class VersionEntity : DamEntity
    {
#region Private fields

        private int _major;

        private int _minor;


#endregion


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
    }
}
