using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// An abstract content item from which all specific multimedia-related content items derive.
    /// </summary>
    public abstract class MultimediaItem : ContentItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public MultimediaItem()
        {
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            CallNumber = string.Empty;
            Dimensions = string.Empty;
            Medium = string.Empty;
            Source = string.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The archive name.
        /// </summary>
        /// <value>
        /// The archive name.
        /// </value>
        public string ArchiveName { get; set; }

        /// <summary>
        /// The archive location.
        /// </summary>
        /// <value>
        /// The archive location.
        /// </value>
        public string ArchiveLocation { get; set; }

        /// <summary>
        /// The call number.
        /// </summary>
        /// <value>
        /// The call number.
        /// </value>
        public string CallNumber { get; set; }

        /// <summary>
        /// The dimensions.
        /// </summary>
        /// <value>
        /// The dimensions.
        /// </value>
        public string Dimensions { get; set; }

        /// <summary>
        /// The medium.
        /// </summary>
        /// <value>
        /// The medium.
        /// </value>
        public string Medium { get; set; }

        /// <summary>
        /// The source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public string Source { get; set; }

        #endregion

    }

}