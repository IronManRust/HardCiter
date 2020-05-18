using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Report : CompositionBase
    {

        #region Constructors

        public Report()
        {
            Number = null;
            Genre = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Report;
            }
        }

        public int? Number { get; set; }

        public string Genre { get; set; }

        #endregion

    }

}