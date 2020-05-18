using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class VideoRecording : Recording
    {

        #region Constructors

        public VideoRecording()
        {
            // No Video Recording-Specific Properties
        }

        #endregion

        #region Properties

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