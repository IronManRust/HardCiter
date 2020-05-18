using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Legislation : GovernmentBase
    {

        #region Constructors

        public Legislation()
        {
            ChapterNumber = null;
            Section = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Legislation;
            }
        }

        public int? ChapterNumber { get; set; }

        public string Section { get; set; }

        #endregion

    }

}