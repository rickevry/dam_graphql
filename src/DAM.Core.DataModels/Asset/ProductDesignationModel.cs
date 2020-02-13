//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:32.131Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAM.Core.DataModels.Base;

namespace DAM.Core.DataModels.Asset
{
    [ModelName("ProductDesignation")]
    [QueryName("ProductDesignation")]
    public class ProductDesignationModel : MutableModel
    {
        private string _designation;

        private string _designationType;

        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                SetField(ref _designation, value);
            }
        }

        public string DesignationType
        {
            get
            {
                return _designationType;
            }
            set
            {
                SetField(ref _designationType, value);
            }
        }
    }
}
