using System;
using Newtonsoft.Json;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class LibraryInformation
    {

        #region Constructors

        public LibraryInformation()
        {
            Name = string.Empty;
            Version = string.Empty;
            Runtime = string.Empty;
        }

        #endregion

        #region Properties

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("runtime")]
        public string Runtime { get; set; }

        #endregion

    }

}