using System;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A webpage.
    /// </summary>
    public class Webpage : ContentItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Webpage()
        {
            ContainerTitle = string.Empty;
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
                return ItemType.Webpage;
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
        /// The genre.
        /// </summary>
        /// <value>
        /// The genre.
        /// </value>
        public string Genre { get; set; }

        #endregion

    }

}