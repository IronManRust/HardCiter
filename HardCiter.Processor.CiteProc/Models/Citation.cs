using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using HardCiter.Processor.CiteProc.Enums;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class Citation
    {

        #region Constructors

        public Citation()
        {
            MetaData = new CitationMetaData();
            ValueValue = new List<List<string>>();
        }

        #endregion

        #region Properties

        [JsonProperty("metadata")]
        public CitationMetaData MetaData { get; set; }

        [JsonProperty("value")]
        private List<List<string>> ValueValue { get; set; }

        public string Value
        {
            get
            {
                if (ValueValue != null &&
                    ValueValue.Count == 1 &&
                    ValueValue[0] != null &&
                    ValueValue[0].Count == 3)
                {
                    return ValueValue[0][1] ?? string.Empty;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

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

            if (!string.IsNullOrEmpty(Value))
            {
                switch (Value)
                {
                    case "([CSL STYLE ERROR: reference with no printed form.])":
                        throw new ArgumentException("Insufficient data to generate a citation.");
                    default:
                        // Do Nothing
                        break;
                }
            }
        }

        #endregion

    }

}