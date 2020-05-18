using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A report.
    /// </summary>
    public class Report : CompositionBase
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Report()
        {
            Number = null;
            Genre = string.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The content item type.
        /// </summary>
        /// <value>
        /// The content item type.
        /// </value>
        public override ItemType ItemType
        {
            get
            {
                return ItemType.Report;
            }
        }

        /// <summary>
        /// The number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int? Number { get; set; }

        /// <summary>
        /// The genre.
        /// </summary>
        /// <value>
        /// The genre.
        /// </value>
        public string Genre { get; set; }

        #endregion

    }

}