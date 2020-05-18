using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A chapter.
    /// </summary>
    public class Chapter : BookBase
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Chapter()
        {
            ContainerAuthors = new List<Creator>();
            ContainerTitle = string.Empty;
            PageNumber = string.Empty;
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
                return ItemType.Chapter;
            }
        }

        /// <summary>
        /// The container authors.
        /// </summary>
        /// <value>
        /// The container authors.
        /// </value>
        public List<Creator> ContainerAuthors { get; set; }

        /// <summary>
        /// The container title.
        /// </summary>
        /// <value>
        /// The container title.
        /// </value>
        public string ContainerTitle { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        /// <value>
        /// The page number.
        /// </value>
        public string PageNumber { get; set; }

        #endregion

    }

}