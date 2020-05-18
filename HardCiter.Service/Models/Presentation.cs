using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A presentation.
    /// </summary>
    public class Presentation : ContentItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Presentation()
        {
            PublisherLocation = string.Empty;
            EventName = string.Empty;
            EventPlace = string.Empty;
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
                return ItemType.Presentation;
            }
        }

        /// <summary>
        /// The publisher's location.
        /// </summary>
        /// <value>
        /// The publisher's location.
        /// </value>
        public string PublisherLocation { get; set; }

        /// <summary>
        /// The event name.
        /// </summary>
        /// <value>
        /// The event name.
        /// </value>
        public string EventName { get; set; }

        /// <summary>
        /// The event place.
        /// </summary>
        /// <value>
        /// The event place.
        /// </value>
        public string EventPlace { get; set; }

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