using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Chapter : BookBase
    {

        #region Constructors

        public Chapter()
        {
            ContainerTitle = string.Empty;
            PageNumber = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Chapter;
            }
        }

        public string ContainerTitle { get; set; }

        public string PageNumber { get; set; }

        #endregion

    }

}