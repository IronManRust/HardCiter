using System;
using System.Collections.Generic;
using System.Linq;
using DE = HardCiter.Domain.Enums;
using PI = HardCiter.Processor.CiteProc.Interfaces;
using PM = HardCiter.Processor.CiteProc.Models;

namespace HardCiter.Processor.CiteProc.Overrides
{

    internal class PublisherNameAbbreviationOverride : PI.IOverrideBibliography, PI.IOverrideCitation
    {

        #region Properties

        public string Purpose
        {
            get
            {
                return "The current style definitions do not abbreviate publisher names; this override takes care of that.";
            }
        }

        #endregion

        #region Methods

        public PM.ContentItem PreProcess(DE.Style style, PM.ContentItem contentItem)
        {
            switch (style)
            {
                case DE.Style.Unknown:
                    // Do Nothing
                    break;
                case DE.Style.MLA7:
                case DE.Style.MLA8:
                    contentItem = PreProcessMLA(contentItem);
                    break;
                case DE.Style.APA5:
                case DE.Style.APA6:
                case DE.Style.APA7:
                    contentItem = PreProcessAPA(contentItem);
                    break;
                case DE.Style.Chicago17:
                    contentItem = PreProcessChicago(contentItem);
                    break;
                case DE.Style.Harvard10:
                case DE.Style.ASA6:
                case DE.Style.Turabian8:
                    // Do Nothing
                    break;
                default:
                    throw new NotImplementedException();
            }

            return contentItem;
        }

        private static PM.ContentItem PreProcessMLA(PM.ContentItem contentItem)
        {
            if (contentItem != null && !string.IsNullOrEmpty(contentItem.PublisherName))
            {
                Dictionary<string, string> terms = new Dictionary<string, string>();
                terms.Add("University Press", "UP");

                Dictionary<string, string> prefixes = new Dictionary<string, string>();
                prefixes.Add("University of ", "U of ");

                Dictionary<string, string> suffixes = new Dictionary<string, string>();
                suffixes.Add(" Press", " P");
                suffixes.Add(" And Companies", string.Empty);
                suffixes.Add(" And Company", string.Empty);
                suffixes.Add(" And Co.", string.Empty);
                suffixes.Add(" And Co", string.Empty);
                suffixes.Add(" & Companies", string.Empty);
                suffixes.Add(" & Company", string.Empty);
                suffixes.Add(" & Co.", string.Empty);
                suffixes.Add(" & Co", string.Empty);
                suffixes.Add(" Companies", string.Empty);
                suffixes.Add(" Company", string.Empty);
                suffixes.Add(" Co.", string.Empty);
                suffixes.Add(" Co", string.Empty);
                suffixes.Add(" Corporations", string.Empty);
                suffixes.Add(" Corporation", string.Empty);
                suffixes.Add(" Corp.", string.Empty);
                suffixes.Add(" Corp", string.Empty);
                suffixes.Add(" Incorporated", string.Empty);
                suffixes.Add(" Inc.", string.Empty);
                suffixes.Add(" Inc", string.Empty);
                suffixes.Add(" Limited", string.Empty);
                suffixes.Add(" Ltd.", string.Empty);
                suffixes.Add(" Ltd", string.Empty);

                contentItem.PublisherName = ReplaceMappings(contentItem.PublisherName, terms, prefixes, suffixes);
            }

            return contentItem;
        }

        private static PM.ContentItem PreProcessAPA(PM.ContentItem contentItem)
        {
            if (contentItem != null && !string.IsNullOrEmpty(contentItem.PublisherName))
            {
                Dictionary<string, string> terms = new Dictionary<string, string>();

                Dictionary<string, string> prefixes = new Dictionary<string, string>();

                Dictionary<string, string> suffixes = new Dictionary<string, string>();
                suffixes.Add(" Publishing", string.Empty);
                suffixes.Add(" Publishers", string.Empty);
                suffixes.Add(" Publisher", string.Empty);
                suffixes.Add(" Pub.", string.Empty);
                suffixes.Add(" Pub", string.Empty);
                suffixes.Add(" And Companies", string.Empty);
                suffixes.Add(" And Company", string.Empty);
                suffixes.Add(" And Co.", string.Empty);
                suffixes.Add(" And Co", string.Empty);
                suffixes.Add(" & Companies", string.Empty);
                suffixes.Add(" & Company", string.Empty);
                suffixes.Add(" & Co.", string.Empty);
                suffixes.Add(" & Co", string.Empty);
                suffixes.Add(" Companies", string.Empty);
                suffixes.Add(" Company", string.Empty);
                suffixes.Add(" Co.", string.Empty);
                suffixes.Add(" Co", string.Empty);
                suffixes.Add(" Incorporated", string.Empty);
                suffixes.Add(" Inc.", string.Empty);
                suffixes.Add(" Inc", string.Empty);

                contentItem.PublisherName = ReplaceMappings(contentItem.PublisherName, terms, prefixes, suffixes);
            }

            return contentItem;
        }

        private static PM.ContentItem PreProcessChicago(PM.ContentItem contentItem)
        {
            if (contentItem != null && !string.IsNullOrEmpty(contentItem.PublisherName))
            {
                Dictionary<string, string> terms = new Dictionary<string, string>();

                Dictionary<string, string> prefixes = new Dictionary<string, string>();
                prefixes.Add("The ", string.Empty);

                Dictionary<string, string> suffixes = new Dictionary<string, string>();
                suffixes.Add(" Publishing", string.Empty);
                suffixes.Add(" Publishers", string.Empty);
                suffixes.Add(" Publisher", string.Empty);
                suffixes.Add(" Pub.", string.Empty);
                suffixes.Add(" Pub", string.Empty);
                suffixes.Add(" And Companies", string.Empty);
                suffixes.Add(" And Company", string.Empty);
                suffixes.Add(" And Co.", string.Empty);
                suffixes.Add(" And Co", string.Empty);
                suffixes.Add(" & Companies", string.Empty);
                suffixes.Add(" & Company", string.Empty);
                suffixes.Add(" & Co.", string.Empty);
                suffixes.Add(" & Co", string.Empty);
                suffixes.Add(" Companies", string.Empty);
                suffixes.Add(" Company", string.Empty);
                suffixes.Add(" Co.", string.Empty);
                suffixes.Add(" Co", string.Empty);
                suffixes.Add(" Incorporated", string.Empty);
                suffixes.Add(" Inc.", string.Empty);
                suffixes.Add(" Inc", string.Empty);
                suffixes.Add(" Limited", string.Empty);
                suffixes.Add(" Ltd.", string.Empty);
                suffixes.Add(" Ltd", string.Empty);
                suffixes.Add(" Société à Responsibilité Limitée", string.Empty);
                suffixes.Add(" SARL", string.Empty);
                suffixes.Add(" Société par Actions Simplifiée", string.Empty);
                suffixes.Add(" SAS", string.Empty);
                suffixes.Add(" Société Anonyme", string.Empty);
                suffixes.Add(" SA", string.Empty);

                contentItem.PublisherName = ReplaceMappings(contentItem.PublisherName, terms, prefixes, suffixes);
            }

            return contentItem;
        }

        private static string ReplaceMappings(string value, Dictionary<string, string> terms, Dictionary<string, string> prefixes, Dictionary<string, string> suffixes)
        {
            if (!string.IsNullOrEmpty(value))
            {
                value = value.Trim();

                // Check Terms

                if (terms != null && terms.Any())
                {
                    bool termFlag = true;
                    while (termFlag)
                    {
                        termFlag = false;
                        foreach (KeyValuePair<string, string> term in terms)
                        {
                            if (value.Contains(term.Key, StringComparison.CurrentCultureIgnoreCase))
                            {
                                value = value.Replace(term.Key, term.Value, StringComparison.CurrentCultureIgnoreCase).Trim();
                                termFlag = true;
                            }
                        }
                    }
                }

                // Check Prefixes

                if (prefixes != null && prefixes.Any())
                {
                    bool prefixFlag = true;
                    while (prefixFlag)
                    {
                        prefixFlag = false;
                        foreach (KeyValuePair<string, string> prefix in prefixes)
                        {
                            if (value.StartsWith(prefix.Key, StringComparison.CurrentCultureIgnoreCase))
                            {
                                value = string.Concat(prefix.Value, value.Substring(prefix.Key.Length)).Trim();
                                prefixFlag = true;
                            }
                        }
                    }
                }

                // Check Suffixes

                if (suffixes != null && suffixes.Any())
                {
                    bool suffixFlag = true;
                    while (suffixFlag)
                    {
                        suffixFlag = false;
                        foreach (KeyValuePair<string, string> suffix in suffixes)
                        {
                            if (value.EndsWith(suffix.Key, StringComparison.CurrentCultureIgnoreCase))
                            {
                                value = string.Concat(value.Substring(0, value.IndexOf(suffix.Key, StringComparison.CurrentCultureIgnoreCase)), suffix.Value).Trim();
                                suffixFlag = true;
                            }
                        }
                    }
                }
            }

            return value;
        }

        public PM.Bibliography PostProcess(DE.Style style, PM.Bibliography bibliography)
        {
            return bibliography;
        }

        public PM.Citation PostProcess(DE.Style style, PM.Citation citation)
        {
            return citation;
        }

        #endregion

    }

}