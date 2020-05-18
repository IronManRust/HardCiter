using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A legislation.
    /// </summary>
    public class Legislation : GovernmentBase
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Legislation()
        {
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
                return ItemType.Legislation;
            }
        }

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