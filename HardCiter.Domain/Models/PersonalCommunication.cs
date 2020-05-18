using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class PersonalCommunication : ContentItem
    {

        #region Constructors

        public PersonalCommunication()
        {
            CallNumber = string.Empty;
            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            Genre = string.Empty;
            Source = string.Empty;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.PersonalCommunication;
            }
        }

        public string CallNumber { get; set; }

        public string ArchiveName { get; set; }

        public string ArchiveLocation { get; set; }

        public string Genre { get; set; }

        public string Source { get; set; }

        #endregion

    }

}