using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Broadcast : MultimediaItem
    {

        #region Constructors

        public Broadcast()
        {
            ContainerTitle = string.Empty;
            Number = null;
            EventPlace = string.Empty;
            PublisherName = string.Empty;
            PublisherLocation = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Broadcast;
            }
        }

        public string ContainerTitle { get; set; }

        public int? Number { get; set; }

        public string EventPlace { get; set; }

        public string PublisherName { get; set; }

        public string PublisherLocation { get; set; }

        #endregion

    }

}