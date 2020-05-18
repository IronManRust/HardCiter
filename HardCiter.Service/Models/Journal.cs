using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A journal.
    /// </summary>
    public class Journal : Article
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Journal()
        {
            CollectionTitle = string.Empty;
            ContainerTitleShort = string.Empty;
            Editors = new List<Creator>();
            DOI = string.Empty;
            Issue = string.Empty;
            Volume = string.Empty;
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
                return ItemType.Journal;
            }
        }

        /// <summary>
        /// The collection's title.
        /// </summary>
        /// <value>
        /// The collection's title.
        /// </value>
        public string CollectionTitle { get; set; }

        /// <summary>
        /// The container's short title.
        /// </summary>
        /// <value>
        /// The container's short title.
        /// </value>
        public string ContainerTitleShort { get; set; }

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
        /// The issue.
        /// </summary>
        /// <value>
        /// The issue.
        /// </value>
        public string Issue { get; set; }

        /// <summary>
        /// The volume.
        /// </summary>
        /// <value>
        /// The volume.
        /// </value>
        public string Volume { get; set; }

        #endregion

    }

}