using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A graphic.
    /// </summary>
    public class Graphic : MultimediaItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Graphic()
        {
            // No Graphic-Specific Properties
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
                return ItemType.Graphic;
            }
        }

        #endregion

    }

}