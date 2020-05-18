using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// A video recording.
    /// </summary>
    public class VideoRecording : Recording
    {

        #region Constructors

        /// <summary>
        /// Initializes the content item.
        /// </summary>
        public VideoRecording()
        {
            // No Video Recording-Specific Properties
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
                return ItemType.VideoRecording;
            }
        }

        #endregion

    }

}