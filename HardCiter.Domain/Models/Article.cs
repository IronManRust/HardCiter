using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public abstract class Article : ContentItem
    {

        #region Constructors

        public Article()
        {
            ISSN = string.Empty;
            CallNumber = string.Empty;
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            ContainerTitleFull = string.Empty;
            PageNumber = string.Empty;
            Source = string.Empty;
        }

        #endregion

        #region Properties

        public string ISSN { get; set; }

        public string CallNumber { get; set; }

        public string ArchiveName { get; set; }

        public string ArchiveLocation { get; set; }

        public string ContainerTitleFull { get; set; }

        public string PageNumber { get; set; }

        public string Source { get; set; }

        #endregion

    }

}