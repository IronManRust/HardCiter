using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Interview : ContentItem
    {

        #region Constructors

        public Interview()
        {
            CallNumber = string.Empty;
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            Medium = string.Empty;
            Source = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Interview;
            }
        }

        public string CallNumber { get; set; }

        public string ArchiveName { get; set; }

        public string ArchiveLocation { get; set; }

        public string Medium { get; set; }

        public string Source { get; set; }

        #endregion

    }

}