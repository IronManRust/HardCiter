using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// An abstract content item from which all specific article-related content items derive.
    /// </summary>
    public abstract class Article : ContentItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Article()
        {
            ISSN = string.Empty;
            CallNumber = string.Empty;
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            ReviewedAuthors = new List<Creator>();
            ContainerTitleFull = string.Empty;
            PageNumber = string.Empty;
            Source = string.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The ISSN.
        /// </summary>
        /// <value>
        /// The ISSN.
        /// </value>
        public string ISSN { get; set; }

        /// <summary>
        /// The call number.
        /// </summary>
        /// <value>
        /// The call number.
        /// </value>
        public string CallNumber { get; set; }

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
        /// The list of the reviewed authors.
        /// </summary>
        /// <value>
        /// The list of the reviewed authors.
        /// </value>
        public List<Creator> ReviewedAuthors { get; set; }

        /// <summary>
        /// The container's full title.
        /// </summary>
        /// <value>
        /// The container's full title.
        /// </value>
        public string ContainerTitleFull { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        /// <value>
        /// The page number.
        /// </value>
        public string PageNumber { get; set; }

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