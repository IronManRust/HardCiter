using System;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A magazine.
    /// </summary>
    public class Magazine : Article
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public Magazine()
        {
            Volume = string.Empty;
            Issue = string.Empty;
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
                return ItemType.Magazine;
            }
        }

        /// <summary>
        /// The volume.
        /// </summary>
        /// <value>
        /// The volume.
        /// </value>
        public string Volume { get; set; }

        /// <summary>
        /// The issue.
        /// </summary>
        /// <value>
        /// The issue.
        /// </value>
        public string Issue { get; set; }

        #endregion

    }

}