using System;
using Newtonsoft.Json;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class BibliographyError
    {

        #region Constructors

        public BibliographyError()
        {
            ItemID = string.Empty;
            Index = 0;
            ErrorCode = string.Empty;
        }

        #endregion

        #region Properties

        [JsonProperty("itemID")]
        public string ItemID { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format($"Item '{ItemID ?? string.Empty}' failed with error code '{ErrorCode ?? string.Empty}'");
        }

        #endregion

    }

}