using System;
using Newtonsoft.Json;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class CitationError
    {

        #region Constructors

        public CitationError()
        {
            ItemID = string.Empty;
            Index = 0;
            ErrorCode = string.Empty;
            CitationID = string.Empty;
            CitationItemPosition = 0;
            NoteIndex = 0;
        }

        #endregion

        #region Properties

        [JsonProperty("itemID")]
        public string ItemID { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("citationID")]
        public string CitationID { get; set; }

        [JsonProperty("citationItem_pos")]
        public int CitationItemPosition { get; set; }

        [JsonProperty("noteIndex")]
        public int NoteIndex { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format($"Item '{ItemID ?? string.Empty}' failed with error code '{ErrorCode ?? string.Empty}'");
        }

        #endregion

    }

}