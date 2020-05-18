using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public abstract class GovernmentBase : ContentItem
    {

        #region Constructors

        public GovernmentBase()
        {
            ContainerTitle = string.Empty;
            PageNumber = string.Empty;
            Number = null;
            References = string.Empty;
            VolumeNumber = string.Empty;
        }

        #endregion

        #region Properties

        public string ContainerTitle { get; set; }

        public string PageNumber { get; set; }

        public int? Number { get; set; }

        public string References { get; set; }

        public string VolumeNumber { get; set; }

        #endregion

    }

}