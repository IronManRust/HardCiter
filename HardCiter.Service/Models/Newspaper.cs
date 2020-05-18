using System;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A newspaper.
    /// </summary>
    public class Newspaper : Article
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Newspaper()
        {
            PublisherLocation = string.Empty;
            EventPlace = string.Empty;
            Edition = string.Empty;
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
                return ItemType.Newspaper;
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
        /// The event place.
        /// </summary>
        /// <value>
        /// The event place.
        /// </value>
        public string EventPlace { get; set; }

        /// <summary>
        /// The edition.
        /// </summary>
        /// <value>
        /// The edition.
        /// </value>
        public string Edition { get; set; }

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