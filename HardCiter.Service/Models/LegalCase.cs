using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A legal case.
    /// </summary>
    public class LegalCase : GovernmentBase
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public LegalCase()
        {
            Authority = string.Empty;
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
                return ItemType.LegalCase;
            }
        }

        /// <summary>
        /// The authority.
        /// </summary>
        /// <value>
        /// The authority.
        /// </value>
        public string Authority { get; set; }

        #endregion

    }

}