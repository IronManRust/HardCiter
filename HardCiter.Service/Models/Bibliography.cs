using System;
using System.Collections.Generic;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A bibliography.
    /// </summary>
    public class Bibliography
    {

        #region Constructors

        /// <summary>
        /// Initializes the bibliography.
        /// </summary>
        public Bibliography()
        {
            SpacingEntry = 0;
            SpacingLine = 0;
            HangingIndent = false;
            Values = new List<string>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// The entry spacing.
        /// </summary>
        /// <value>
        /// The entry spacing.
        /// </value>
        public int SpacingEntry { get; set; }

        /// <summary>
        /// The line spacing.
        /// </summary>
        /// <value>
        /// The line spacing.
        /// </value>
        public int SpacingLine { get; set; }

        /// <summary>
        /// The hanging indent.
        /// </summary>
        /// <value>
        /// The hanging indent.
        /// </value>
        public bool HangingIndent { get; set; }

        /// <summary>
        /// The values.
        /// </summary>
        /// <value>
        /// The values.
        /// </value>
        public List<string> Values { get; set; }

        #endregion

    }

}