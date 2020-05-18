using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Magazine : Article
    {

        #region Constructors

        public Magazine()
        {
            Volume = string.Empty;
            Issue = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Magazine;
            }
        }

        public string Volume { get; set; }

        public string Issue { get; set; }

        #endregion

    }

}