using System;
using System.Collections.Generic;
using System.Linq;
using DE = HardCiter.Domain.Enums;
using PI = HardCiter.Processor.CiteProc.Interfaces;
using PM = HardCiter.Processor.CiteProc.Models;
using PO = HardCiter.Processor.CiteProc.Overrides;

namespace HardCiter.Processor.CiteProc.Managers
{

    internal class OverrideManager
    {

        #region Variables

        private List<PI.IOverrideBibliography> _overridesBibliography;
        private List<PI.IOverrideCitation> _overridesCitation;

        #endregion

        #region Constructors

        internal OverrideManager()
        {
            _overridesBibliography = new List<PI.IOverrideBibliography>()
            {
                new PO.NonConsecutivePagesOverride(),
                new PO.PublisherNameAbbreviationOverride()
            };
            _overridesCitation = new List<PI.IOverrideCitation>()
            {
                // No Overrides
            };
        }

        #endregion

        #region Methods

        internal List<PM.ContentItem> PreProcessBibliography(DE.Style style, List<PM.ContentItem> contentItems)
        {
            if (contentItems != null)
            {
                List<PM.ContentItem> results = new List<PM.ContentItem>();
                foreach (PM.ContentItem contentItem in contentItems)
                {
                    if (contentItem != null)
                    {
                        PM.ContentItem result = contentItem;
                        _overridesBibliography.ForEach(x => result = x.PreProcess(style, result));
                        results.Add(result);
                    }
                    else
                    {
                        results.Add(contentItem);
                    }
                }
                return results;
            }
            else
            {
                return contentItems;
            }
        }

        internal List<PM.ContentItem> PreProcessCitation(DE.Style style, List<PM.ContentItem> contentItems)
        {
            if (contentItems != null)
            {
                List<PM.ContentItem> results = new List<PM.ContentItem>();
                foreach (PM.ContentItem contentItem in contentItems)
                {
                    if (contentItem != null)
                    {
                        PM.ContentItem result = contentItem;
                        _overridesCitation.ForEach(x => result = x.PreProcess(style, result));
                        results.Add(result);
                    }
                    else
                    {
                        results.Add(contentItem);
                    }
                }
                return results;
            }
            else
            {
                return contentItems;
            }
        }

        internal PM.Bibliography PostProcessBibliography(DE.Style style, PM.Bibliography bibliography)
        {
            if (bibliography != null)
            {
                _overridesBibliography.ForEach(x => bibliography = x.PostProcess(style, bibliography));
            }

            return bibliography;
        }

        internal PM.Citation PostProcessCitation(DE.Style style, PM.Citation citation)
        {
            if (citation != null)
            {
                _overridesCitation.ForEach(x => citation = x.PostProcess(style, citation));
            }

            return citation;
        }

        #endregion

    }

}