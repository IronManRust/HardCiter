using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public abstract class CompositionBase : ContentItem
    {

        #region Constructors

        public CompositionBase()
        {
            PublisherName = string.Empty;
            PublisherLocation = string.Empty;
            CallNumber = string.Empty;
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            CollectionTitle = string.Empty;
            PageNumber = string.Empty;
            Source = string.Empty;
            EventPlace = string.Empty;
        }

        #endregion

        #region Properties

        public string PublisherName { get; set; }

        public string PublisherLocation { get; set; }

        public string CallNumber { get; set; }

        public string ArchiveName { get; set; }

        public string ArchiveLocation { get; set; }

        public string CollectionTitle { get; set; }

        public string PageNumber { get; set; }

        public string Source { get; set; }

        public string EventPlace { get; set; }

        #endregion

    }

}