using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Presentation : ContentItem
    {

        #region Constructors

        public Presentation()
        {
            PublisherLocation = string.Empty;
            EventName = string.Empty;
            EventPlace = string.Empty;
            Genre = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Presentation;
            }
        }

        public string PublisherLocation { get; set; }

        public string EventName { get; set; }

        public string EventPlace { get; set; }

        public string Genre { get; set; }

        #endregion

    }

}