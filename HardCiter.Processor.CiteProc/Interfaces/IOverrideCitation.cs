using System;
using DE = HardCiter.Domain.Enums;
using PM = HardCiter.Processor.CiteProc.Models;

namespace HardCiter.Processor.CiteProc.Interfaces
{

    public interface IOverrideCitation
    {

        #region Properties

        string Purpose { get; }

        #endregion

        #region Methods

        PM.ContentItem PreProcess(DE.Style style, PM.ContentItem contentItem);

        PM.Citation PostProcess(DE.Style style, PM.Citation citation);

        #endregion

    }

}