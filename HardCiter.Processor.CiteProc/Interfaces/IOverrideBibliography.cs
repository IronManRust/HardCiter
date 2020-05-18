using System;
using DE = HardCiter.Domain.Enums;
using PM = HardCiter.Processor.CiteProc.Models;

namespace HardCiter.Processor.CiteProc.Interfaces
{

    public interface IOverrideBibliography
    {

        #region Properties

        string Purpose { get; }

        #endregion

        #region Methods

        PM.ContentItem PreProcess(DE.Style style, PM.ContentItem contentItem);

        PM.Bibliography PostProcess(DE.Style style, PM.Bibliography bibliography);

        #endregion

    }

}