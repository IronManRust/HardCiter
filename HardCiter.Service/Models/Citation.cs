using System;
using System.Collections.Generic;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A citation.
    /// </summary>
    public class Citation
    {

        #region Constructors

        /// <summary>
        /// Initializes the citation.
        /// </summary>
        public Citation()
        {
            Value = string.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }

        #endregion

    }

}