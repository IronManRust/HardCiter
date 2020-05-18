using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// An audio recording.
    /// </summary>
    public class AudioRecording : Recording
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public AudioRecording()
        {
            Composers = new List<Creator>();
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
                return ItemType.AudioRecording;
            }
        }

        /// <summary>
        /// The composers.
        /// </summary>
        /// <value>
        /// The composers.
        /// </value>
        public List<Creator> Composers { get; set; }

        #endregion

    }

}