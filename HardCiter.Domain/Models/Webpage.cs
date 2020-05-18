using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Webpage : ContentItem
    {

        #region Constructors

        public Webpage()
        {
            ContainerTitle = string.Empty;
            Genre = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Webpage;
            }
        }

        public string ContainerTitle { get; set; }

        public string Genre { get; set; }

        #endregion

    }

}