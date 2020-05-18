using System;
using Newtonsoft.Json;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class Creator
    {

        #region Constructors

        public Creator()
        {
            Full = string.Empty;
            Given = string.Empty;
            Family = string.Empty;
            ParticleDropping = string.Empty;
            ParticleNonDropping = string.Empty;
            Suffix = string.Empty;
        }

        #endregion

        #region Properties

        [JsonProperty("literal")]
        public string Full { get; set; }

        [JsonProperty("given")]
        public string Given { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("dropping-particle")]
        public string ParticleDropping { get; set; }

        [JsonProperty("non-dropping-particle")]
        public string ParticleNonDropping { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        #endregion

    }

}