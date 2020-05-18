using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public abstract class BookBase : ContentItem
    {

        #region Constructors

        public BookBase()
        {
            PublisherName = string.Empty;
            PublisherLocation = string.Empty;
            ISBN = string.Empty;
            CallNumber = string.Empty;
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            CollectionTitle = string.Empty;
            CollectionNumber = null;
            Edition = string.Empty;
            VolumeNumber = string.Empty;
            VolumeCount = null;
            Source = string.Empty;
            EventPlace = string.Empty;
        }

        #endregion

        #region Properties

        public string PublisherName { get; set; }

        public string PublisherLocation { get; set; }

        public string ISBN { get; set; }

        public string CallNumber { get; set; }

        public string ArchiveName { get; set; }

        public string ArchiveLocation { get; set; }

        public string CollectionTitle { get; set; }

        public int? CollectionNumber { get; set; }

        public string Edition { get; set; }

        public string VolumeNumber { get; set; }

        public int? VolumeCount { get; set; }

        public string Source { get; set; }

        public string EventPlace { get; set; }

        #endregion

    }

}