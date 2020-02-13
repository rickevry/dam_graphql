//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:31.880Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAM.Core.DataModels.Base;

namespace DAM.Core.DataModels.Bundle
{
    [ModelName("Version")]
    [QueryName("versions")]
    public class VersionModel : MutableModel
    {
        private int _major;

        private int _minor;

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
