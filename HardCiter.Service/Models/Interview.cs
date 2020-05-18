using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// An interview.
    /// </summary>
    public class Interview : ContentItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Interview()
        {
            Interviewers = new List<Creator>();
            CallNumber = string.Empty;
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            Medium = string.Empty;
            Source = string.Empty;
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
                return ItemType.Interview;
            }
        }

        /// <summary>
        /// The interviewers.
        /// </summary>
        /// <value>
        /// The interviewers.
        /// </value>
        public List<Creator> Interviewers { get; set; }

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
        /// The medium.
        /// </summary>
        /// <value>
        /// The medium.
        /// </value>
        public string Medium { get; set; }

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