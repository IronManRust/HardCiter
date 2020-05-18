using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Bill : GovernmentBase
    {

        #region Constructors

        public Bill()
        {
            Authority = string.Empty;
            ChapterNumber = null;
            Section = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Bill;
            }
        }

        public string Authority { get; set; }

        public int? ChapterNumber { get; set; }

        public string Section { get; set; }

        #endregion

    }

}