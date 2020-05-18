using System;
using System.Collections.Generic;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public abstract class ContentItem
    {

        #region Constructors

        public ContentItem()
        {
            TitleFull = string.Empty;
            TitleShort = string.Empty;
            Creators = new List<Creator>();
            AccessedDate = null;
            IssuedDate = null;
            Abstract = string.Empty;
            Language = string.Empty;
            Note = string.Empty;
            URL = string.Empty;
        }

        #endregion

        #region Properties

        public abstract ItemType ItemType { get; }

        public string TitleFull { get; set; }

        public string TitleShort { get; set; }

        public List<Creator> Creators { get; set; }

        public DateInformation AccessedDate { get; set; }

        public DateInformation IssuedDate { get; set; }

        public string Abstract { get; set; }

        public string Language { get; set; }

        public string Note { get; set; }

        public string URL { get; set; }

        #endregion

    }

}