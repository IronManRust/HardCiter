using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Journal : Article
    {

        #region Constructors

        public Journal()
        {
            CollectionTitle = string.Empty;
            ContainerTitleShort = string.Empty;
            DOI = string.Empty;
            Issue = string.Empty;
            Volume = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Journal;
            }
        }

        public string CollectionTitle { get; set; }

        public string ContainerTitleShort { get; set; }

        public string DOI { get; set; }

        public string Issue { get; set; }

        public string Volume { get; set; }

        #endregion

    }

}