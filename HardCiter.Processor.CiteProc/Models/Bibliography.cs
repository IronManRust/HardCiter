using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using HardCiter.Processor.CiteProc.Enums;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class Bibliography
    {

        #region Constructors

        public Bibliography()
        {
            MetaData = new BibliographyMetaData();
            Values = new List<string>();
        }

        #endregion

        #region Properties

        [JsonProperty("metadata")]
        public BibliographyMetaData MetaData { get; set; }

        [JsonProperty("value")]
        public List<string> Values { get; set; }

        #endregion

        #region Methods

        public void ProcessExceptions()
        {
            if (MetaData != null &&
                MetaData.Errors != null &&
                MetaData.Errors.Any())
            {
                if (MetaData.Errors.Count == 1)
                {
                    throw new ArgumentException(MetaData.Errors.First().ToString());
                }
                else
                {
                    throw new AggregateException(MetaData.Errors.Select(x => new ArgumentException(x.ToString())));
                }
            }
        }

        #endregion

    }

}