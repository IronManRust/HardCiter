using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public abstract class MultimediaItem : ContentItem
    {

        #region Constructors

        public MultimediaItem()
        {
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            CallNumber = string.Empty;
            Dimensions = string.Empty;
            Medium = string.Empty;
            Source = string.Empty;
        }

        #endregion

        #region Properties

        public string ArchiveName { get; set; }

        public string ArchiveLocation { get; set; }

        public string CallNumber { get; set; }

        public string Dimensions { get; set; }

        public string Medium { get; set; }

        public string Source { get; set; }

        #endregion

    }

}