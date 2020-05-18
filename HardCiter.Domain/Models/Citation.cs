using System;
using System.Collections.Generic;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Citation
    {

        #region Constructors

        public Citation()
        {
            Value = string.Empty;
        }

        #endregion

        #region Properties

        public string Value { get; set; }

        #endregion

    }

}