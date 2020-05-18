using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class AudioRecording : Recording
    {

        #region Constructors

        public AudioRecording()
        {
            // No Audio Recording-Specific Properties
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.AudioRecording;
            }
        }

        #endregion

    }

}