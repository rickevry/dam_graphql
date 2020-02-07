//
//  This file was automatically generated and should not be edited.
//  2020-02-07T10:08:59.144Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dam.Repository;
using Dam.Repository.Attributes;
using Dam.Schemas.Attributes;

namespace Dam.Schemas.Entities.Bundle
{
    [EntityName("Version")]
    [QueryName("versions")]
    public class VersionEntity : MutableEntity
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
