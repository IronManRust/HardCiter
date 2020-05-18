using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// An abstract content item from which all specific recording-related content items derive.
    /// </summary>
    public abstract class Recording : MultimediaItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Recording()
        {
            CollectionTitle = string.Empty;
            EventPlace = string.Empty;
            ISBN = string.Empty;
            VolumeNumber = string.Empty;
            VolumeCount = null;
            PublisherName = string.Empty;
            PublisherLocation = string.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The collection's title.
        /// </summary>
        /// <value>
        /// The collection's title.
        /// </value>
        public string CollectionTitle { get; set; }

        /// <summary>
        /// The event place.
        /// </summary>
        /// <value>
        /// The event place.
        /// </value>
        public string EventPlace { get; set; }

        /// <summary>
        /// The ISBN.
        /// </summary>
        /// <value>
        /// The ISBN.
        /// </value>
        public string ISBN { get; set; }

        /// <summary>
        /// The volume number.
        /// </summary>
        /// <value>
        /// The volume number.
        /// </value>
        public string VolumeNumber { get; set; }

        /// <summary>
        /// The number of volumes.
        /// </summary>
        /// <value>
        /// The number of volumes.
        /// </value>
        public int? VolumeCount { get; set; }

        /// <summary>
        /// The publisher's name.
        /// </summary>
        /// <value>
        /// The publisher's name.
        /// </value>
        public string PublisherName { get; set; }

        /// <summary>
        /// The publisher's location.
        /// </summary>
        /// <value>
        /// The publisher's location.
        /// </value>
        public string PublisherLocation { get; set; }

        #endregion

    }

}