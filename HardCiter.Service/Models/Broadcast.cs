using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A broadcast.
    /// </summary>
    public class Broadcast : MultimediaItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Broadcast()
        {
            ContainerTitle = string.Empty;
            Number = null;
            EventPlace = string.Empty;
            PublisherName = string.Empty;
            PublisherLocation = string.Empty;
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
                return ItemType.Broadcast;
            }
        }

        /// <summary>
        /// The container's title.
        /// </summary>
        /// <value>
        /// The container's title.
        /// </value>
        public string ContainerTitle { get; set; }

        /// <summary>
        /// The number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int? Number { get; set; }

        /// <summary>
        /// The event place.
        /// </summary>
        /// <value>
        /// The event place.
        /// </value>
        public string EventPlace { get; set; }

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