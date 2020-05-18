using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class LegalCase : GovernmentBase
    {

        #region Constructors

        public LegalCase()
        {
            Authority = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.LegalCase;
            }
        }

        public string Authority { get; set; }

        #endregion

    }

}