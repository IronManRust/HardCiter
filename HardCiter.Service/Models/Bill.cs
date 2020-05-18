using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A bill.
    /// </summary>
    public class Bill : GovernmentBase
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Bill()
        {
            Authority = string.Empty;
            ChapterNumber = null;
            Section = string.Empty;
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
                return ItemType.Bill;
            }
        }

        /// <summary>
        /// The authority.
        /// </summary>
        /// <value>
        /// The authority.
        /// </value>
        public string Authority { get; set; }

        /// <summary>
        /// The chapter number.
        /// </summary>
        /// <value>
        /// The chapter number.
        /// </value>
        public int? ChapterNumber { get; set; }

        /// <summary>
        /// The section.
        /// </summary>
        /// <value>
        /// The section.
        /// </value>
        public string Section { get; set; }

        #endregion

    }

}