using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using HardCiter.Processor.CiteProc.Enums;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class CitationMetaData
    {

        #region Constructors

        public CitationMetaData()
        {
            Change = false;
            Errors = new List<CitationError>();
        }

        #endregion

        #region Properties

        [JsonProperty("bibchange")]
        public bool Change { get; set; }

        [JsonProperty("citation_errors")]
        public List<CitationError> Errors { get; set; }

        #endregion

    }

}