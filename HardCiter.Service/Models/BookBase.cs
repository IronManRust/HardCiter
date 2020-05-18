using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// An abstract content item from which all specific book-related content items derive.
    /// </summary>
    public abstract class BookBase : ContentItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public BookBase()
        {
            PublisherName = string.Empty;
            PublisherLocation = string.Empty;
            ISBN = string.Empty;
            CallNumber = string.Empty;
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            Editors = new List<Creator>();
            CollectionEditors = new List<Creator>();
            CollectionTitle = string.Empty;
            CollectionNumber = null;
            Edition = string.Empty;
            VolumeNumber = string.Empty;
            VolumeCount = null;
            Source = string.Empty;
            EventPlace = string.Empty;
        }

        #endregion

        #region Properties

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

        /// <summary>
        /// The ISBN.
        /// </summary>
        /// <value>
        /// The ISBN.
        /// </value>
        public string ISBN { get; set; }

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
        /// The list of editors.
        /// </summary>
        /// <value>
        /// The list of editors.
        /// </value>
        public List<Creator> Editors { get; set; }

        /// <summary>
        /// The list of the collection's editors.
        /// </summary>
        /// <value>
        /// The list of the collection's editors.
        /// </value>
        public List<Creator> CollectionEditors { get; set; }

        /// <summary>
        /// The collection's title.
        /// </summary>
        /// <value>
        /// The collection's title.
        /// </value>
        public string CollectionTitle { get; set; }

        /// <summary>
        /// The collection's number.
        /// </summary>
        /// <value>
        /// The collection's number.
        /// </value>
        public int? CollectionNumber { get; set; }

        /// <summary>
        /// The edition number.
        /// </summary>
        /// <value>
        /// The edition number.
        /// </value>
        public string Edition { get; set; }

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
        /// The source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public string Source { get; set; }

        /// <summary>
        /// The event place.
        /// </summary>
        /// <value>
        /// The event place.
        /// </value>
        public string EventPlace { get; set; }

        #endregion

    }

}