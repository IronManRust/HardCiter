using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Newspaper : Article
    {

        #region Constructors

        public Newspaper()
        {
            PublisherLocation = string.Empty;
            EventPlace = string.Empty;
            Edition = string.Empty;
            Section = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Newspaper;
            }
        }

        public string PublisherLocation { get; set; }

        public string EventPlace { get; set; }

        public string Edition { get; set; }

        public string Section { get; set; }

        #endregion

    }

}