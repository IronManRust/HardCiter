using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Map : ContentItem
    {

        #region Constructors

        public Map()
        {
            PublisherName = string.Empty;
            PublisherLocation = string.Empty;
            ISBN = string.Empty;
            CallNumber = string.Empty;
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            CollectionTitle = string.Empty;
            Edition = string.Empty;
            Genre = string.Empty;
            Source = string.Empty;
            EventPlace = string.Empty;
            Scale = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Map;
            }
        }

        public string PublisherName { get; set; }

        public string PublisherLocation { get; set; }

        public string ISBN { get; set; }

        public string CallNumber { get; set; }

        public string ArchiveName { get; set; }

        public string ArchiveLocation { get; set; }

        public string CollectionTitle { get; set; }

        public string Edition { get; set; }

        public string Genre { get; set; }

        public string Source { get; set; }

        public string EventPlace { get; set; }

        public string Scale { get; set; }

        #endregion

    }

}