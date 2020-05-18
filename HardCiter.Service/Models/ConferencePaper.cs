using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A conference paper.
    /// </summary>
    public class ConferencePaper : CompositionBase
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public ConferencePaper()
        {
            ISBN = string.Empty;
            Editors = new List<Creator>();
            DOI = string.Empty;
            ContainerTitle = string.Empty;
            EventName = string.Empty;
            VolumeNumber = string.Empty;
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
                return ItemType.ConferencePaper;
            }
        }

        /// <summary>
        /// The ISBN.
        /// </summary>
        /// <value>
        /// The ISBN.
        /// </value>
        public string ISBN { get; set; }

        /// <summary>
        /// The list of editors.
        /// </summary>
        /// <value>
        /// The list of editors.
        /// </value>
        public List<Creator> Editors { get; set; }

        /// <summary>
        /// The DOI.
        /// </summary>
        /// <value>
        /// The DOI.
        /// </value>
        public string DOI { get; set; }

        /// <summary>
        /// The container's title.
        /// </summary>
        /// <value>
        /// The container's title.
        /// </value>
        public string ContainerTitle { get; set; }

        /// <summary>
        /// The event name.
        /// </summary>
        /// <value>
        /// The event name.
        /// </value>
        public string EventName { get; set; }

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