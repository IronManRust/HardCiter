using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using HardCiter.Processor.CiteProc.Enums;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class BibliographyMetaData
    {

        #region Constructors

        public BibliographyMetaData()
        {
            Done = false;
            EntryIDs = new List<List<string>>();
            Errors = new List<BibliographyError>();
            Prefix = string.Empty;
            Suffix = string.Empty;
            SpacingEntry = 0;
            SpacingLine = 0;
            SecondFieldAlignmentValue = string.Empty;
            MaxOffset = 0;
            HangingIndent = false;
        }

        #endregion

        #region Properties

        [JsonProperty("done")]
        public bool Done { get; set; }

        [JsonProperty("entry_ids")]
        public List<List<string>> EntryIDs { get; set; }

        [JsonProperty("bibliography_errors")]
        public List<BibliographyError> Errors { get; set; }

        [JsonProperty("bibstart")]
        public string Prefix { get; set; }

        [JsonProperty("bibend")]
        public string Suffix { get; set; }

        [JsonProperty("entryspacing")]
        public int SpacingEntry { get; set; }

        [JsonProperty("linespacing")]
        public int SpacingLine { get; set; }

        [JsonProperty("second-field-align")]
        private string SecondFieldAlignmentValue { get; set; }

        public SecondFieldAlignment SecondFieldAlignment
        {
            get
            {
                if (!string.IsNullOrEmpty(SecondFieldAlignmentValue))
                {
                    switch (SecondFieldAlignmentValue)
                    {
                        case "false":
                            return SecondFieldAlignment.None;
                        case "flush":
                            return SecondFieldAlignment.Flush;
                        case "margin":
                            return SecondFieldAlignment.Margin;
                        default:
                            return SecondFieldAlignment.None;
                    }
                }
                else
                {
                    return SecondFieldAlignment.None;
                }
            }
        }

        [JsonProperty("maxoffset")]
        public int MaxOffset { get; set; }

        [JsonProperty("hangingindent")]
        public bool HangingIndent { get; set; }

        #endregion

    }

}