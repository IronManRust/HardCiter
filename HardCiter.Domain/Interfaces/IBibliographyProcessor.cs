using System;
using System.Collections.Generic;
using DE = HardCiter.Domain.Enums;
using DM = HardCiter.Domain.Models;

namespace HardCiter.Domain.Interfaces
{

    public interface IBibliographyProcessor
    {

        #region Methods

        List<KeyValuePair<string, string>> GetMetaData();

        DM.Bibliography CreateBibliography(DE.Style style, DE.Format format, List<DM.ContentItem> contentItems);

        #endregion

    }

}