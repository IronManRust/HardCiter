using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Graphic : MultimediaItem
    {

        #region Constructors

        public Graphic()
        {
            // No Graphic-Specific Properties
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Graphic;
            }
        }

        #endregion

    }

}