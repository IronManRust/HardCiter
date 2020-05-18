using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Creator
    {

        #region Constructors

        public Creator()
        {
            Type = CreatorType.Unknown;
            Full = string.Empty;
            Given = string.Empty;
            Family = string.Empty;
            ParticleDropping = string.Empty;
            ParticleNonDropping = string.Empty;
            Suffix = string.Empty;
        }

        #endregion

        #region Properties

        public CreatorType Type { get; set; }

        public string Full { get; set; }

        public string Given { get; set; }

        public string Family { get; set; }

        public string ParticleDropping { get; set; }

        public string ParticleNonDropping { get; set; }

        public string Suffix { get; set; }

        #endregion

    }

}