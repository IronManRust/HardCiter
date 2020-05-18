using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class ConferencePaper : CompositionBase
    {

        #region Constructors

        public ConferencePaper()
        {
            ISBN = string.Empty;
            DOI = string.Empty;
            ContainerTitle = string.Empty;
            EventName = string.Empty;
            VolumeNumber = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.ConferencePaper;
            }
        }

        public string ISBN { get; set; }

        public string DOI { get; set; }

        public string ContainerTitle { get; set; }

        public string EventName { get; set; }

        public string VolumeNumber { get; set; }

        #endregion

    }

}