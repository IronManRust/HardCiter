using System;
using System.Collections.Generic;
using System.Linq;
using DE = HardCiter.Domain.Enums;
using PI = HardCiter.Processor.CiteProc.Interfaces;
using PM = HardCiter.Processor.CiteProc.Models;

namespace HardCiter.Processor.CiteProc.Overrides
{

    internal class NonConsecutivePagesOverride : PI.IOverrideBibliography, PI.IOverrideCitation
    {

        #region Variables

        private Dictionary<string, string> _mappings;

        #endregion

        #region Constructors

        internal NonConsecutivePagesOverride()
        {
            _mappings = new Dictionary<string, string>();
        }

        #endregion

        #region Properties

        public string Purpose
        {
            get
            {
                return "As of at least v1.2.2 of the CiteProc.js library, the PageNumber property only gets flagged as multiple if the data is of the formats 'xxx, yyy' or 'xxx-yyy' and ignores the format 'xxx+' which according to spec is also valid. This determines if 'p.' or 'pp.' should be the bibliography prefix. As such, this override substitutes a GUID for 'xxx+' to trigger the correct behavior, and then replaces the data on the return. The use of a GUID *should* ensure no side-effects to using a crude string-replace routine.";
            }
        }

        #endregion

        #region Methods

        public PM.ContentItem PreProcess(DE.Style style, PM.ContentItem contentItem)
        {
            if (contentItem != null)
            {
                if (!string.IsNullOrEmpty(contentItem.PageNumber) && contentItem.PageNumber.EndsWith("+"))
                {
                    int hash1 = Math.Abs(Guid.NewGuid().GetHashCode());
                    int hash2 = Math.Abs(Guid.NewGuid().GetHashCode());
                    string replacement = string.Concat(Math.Min(hash1, hash2).ToString(),
                                                       ", ",
                                                       Math.Max(hash1, hash2).ToString());
                    _mappings.Add(replacement, contentItem.PageNumber);
                    contentItem.PageNumber = replacement;
                }
            }

            return contentItem;
        }

        public PM.Bibliography PostProcess(DE.Style style, PM.Bibliography bibliography)
        {
            if (bibliography != null && bibliography.Values != null)
            {
                List<string> replacedValues = new List<string>();
                foreach (string value in bibliography.Values)
                {
                    string replacedValue = value;
                    foreach (KeyValuePair<string, string> mapping in _mappings)
                    {
                        if (!string.IsNullOrEmpty(replacedValue) &&
                            !string.IsNullOrEmpty(mapping.Key) &&
                            !string.IsNullOrEmpty(mapping.Value))
                        {
                            replacedValue = replacedValue.Replace(mapping.Key, mapping.Value);
                        }
                    }
                    replacedValues.Add(replacedValue);
                }
                bibliography.Values = replacedValues;
            }

            return bibliography;
        }

        public PM.Citation PostProcess(DE.Style style, PM.Citation citation)
        {
            return citation;
        }

        #endregion

    }

}