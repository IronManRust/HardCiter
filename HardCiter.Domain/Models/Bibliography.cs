using System;
using System.Collections.Generic;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Bibliography
    {

        #region Constructors

        public Bibliography()
        {
            SpacingEntry = 0;
            SpacingLine = 0;
            HangingIndent = false;
            Values = new List<string>();
        }

        #endregion

        #region Properties

        public int SpacingEntry { get; set; }

        public int SpacingLine { get; set; }

        public bool HangingIndent { get; set; }

        public List<string> Values { get; set; }

        #endregion

    }

}