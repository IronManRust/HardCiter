using System;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// Describes a creator associated with a content item.
    /// </summary>
    public class Creator
    {

        #region Constructors

        /// <summary>
        /// Initializes a creator object.
        /// </summary>
        public Creator()
        {
            Full = string.Empty;
            Given = string.Empty;
            Family = string.Empty;
            ParticleDropping = string.Empty;
            ParticleNonDropping = string.Empty;
            Suffix = string.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The creator's full name.
        /// </summary>
        /// <value>
        /// The creator's full name.
        /// </value>
        public string Full { get; set; }

        /// <summary>
        /// The creator's given / first name.
        /// </summary>
        /// <value>
        /// The creator's given / first name.
        /// </value>
        public string Given { get; set; }

        /// <summary>
        /// The creator's family / last name.
        /// </summary>
        /// <value>
        /// The creator's family / last name.
        /// </value>
        public string Family { get; set; }

        /// <summary>
        /// The creator's dropping particle (i.e. von).
        /// </summary>
        /// <value>
        /// The creator's dropping particle (i.e. von).
        /// </value>
        public string ParticleDropping { get; set; }

        /// <summary>
        /// The creator's non-dropping particle (i.e. van).
        /// </summary>
        /// <value>
        /// The creator's non-dropping particle (i.e. van).
        /// </value>
        public string ParticleNonDropping { get; set; }

        /// <summary>
        /// The creator's suffix (i.e. Jr / III).
        /// </summary>
        /// <value>
        /// The creator's suffix (i.e. Jr / III).
        /// </value>
        public string Suffix { get; set; }

        #endregion

    }

}