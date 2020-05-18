using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// An abstract content item from which all specific content items derive.
    /// </summary>
    public abstract class ContentItem
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public ContentItem()
        {
            TitleFull = string.Empty;
            TitleShort = string.Empty;
            Authors = new List<Creator>();
            Translators = new List<Creator>();
            AccessedDate = null;
            IssuedDate = null;
            Abstract = string.Empty;
            Language = string.Empty;
            Note = string.Empty;
            URL = string.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The content item type.
        /// </summary>
        /// <value>
        /// The content item type.
        /// </value>
        public abstract ItemType ItemType { get; }

        internal static string Discriminator
        {
            get
            {
                return "itemType";
            }
        }

        /// <summary>
        /// The full title.
        /// </summary>
        /// <value>
        /// The full title.
        /// </value>
        public string TitleFull { get; set; }

        /// <summary>
        /// The short title.
        /// </summary>
        /// <value>
        /// The short title.
        /// </value>
        public string TitleShort { get; set; }

        /// <summary>
        /// The list of authors.
        /// </summary>
        /// <value>
        /// The list of authors.
        /// </value>
        public List<Creator> Authors { get; set; }

        /// <summary>
        /// The list of translators.
        /// </summary>
        /// <value>
        /// The list of translators.
        /// </value>
        public List<Creator> Translators { get; set; }

        /// <summary>
        /// The accessed date.
        /// </summary>
        /// <value>
        /// The accessed date.
        /// </value>
        public DateInformation AccessedDate { get; set; }

        /// <summary>
        /// The issued date.
        /// </summary>
        /// <value>
        /// The issued date.
        /// </value>
        public DateInformation IssuedDate { get; set; }

        /// <summary>
        /// The abstract.
        /// </summary>
        /// <value>
        /// The abstract.
        /// </value>
        public string Abstract { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        public string Language { get; set; }

        /// <summary>
        /// The note.
        /// </summary>
        /// <value>
        /// The note.
        /// </value>
        public string Note { get; set; }

        /// <summary>
        /// The URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string URL { get; set; }

        #endregion

    }

}