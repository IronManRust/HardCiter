using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public abstract class Recording : MultimediaItem
    {

        #region Constructors

        public Recording()
        {
            CollectionTitle = string.Empty;
            EventPlace = string.Empty;
            ISBN = string.Empty;
            VolumeNumber = string.Empty;
            VolumeCount = null;
            PublisherName = string.Empty;
            PublisherLocation = string.Empty;
        }

        #endregion

        #region Properties

        public string CollectionTitle { get; set; }

        public string EventPlace { get; set; }

        public string ISBN { get; set; }

        public string VolumeNumber { get; set; }

        public int? VolumeCount { get; set; }

        public string PublisherName { get; set; }

        public string PublisherLocation { get; set; }

        #endregion

    }

}