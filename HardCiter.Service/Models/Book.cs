using System;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A book.
    /// </summary>
    public class Book : BookBase
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Book()
        {
            PageCount = null;
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
                return ItemType.Book;
            }
        }

        /// <summary>
        /// The number of pages.
        /// </summary>
        /// <value>
        /// The number of pages.
        /// </value>
        public int? PageCount { get; set; }

        #endregion

    }

}