using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// An abstract content item from which all specific government-related content items derive.
    /// </summary>
    public abstract class GovernmentBase : ContentItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public GovernmentBase()
        {
            ContainerTitle = string.Empty;
            PageNumber = string.Empty;
            Number = null;
            References = string.Empty;
            VolumeNumber = string.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The container's title.
        /// </summary>
        /// <value>
        /// The container's title.
        /// </value>
        public string ContainerTitle { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        /// <value>
        /// The page number.
        /// </value>
        public string PageNumber { get; set; }

        /// <summary>
        /// The number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int? Number { get; set; }

        /// <summary>
        /// The references.
        /// </summary>
        /// <value>
        /// The references.
        /// </value>
        public string References { get; set; }

        /// <summary>
        /// The volume number.
        /// </summary>
        /// <value>
        /// The volume number.
        /// </value>
        public string VolumeNumber { get; set; }

        #endregion

    }

}