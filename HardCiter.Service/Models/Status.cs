using System;
using System.Collections.Generic;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// Describes the status of the service.
    /// </summary>
    public class Status
    {

        #region Constructors

        /// <summary>
        /// Initializes the service status object.
        /// </summary>
        public Status()
        {
            Health = Health.Unhealthy;
            Environment = string.Empty;
            MetaData = new List<KeyValuePair<string, string>>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// The health of the service.
        /// </summary>
        /// <value>
        /// The health of the service.
        /// </value>
        public Health Health { get; set; }

        /// <summary>
        /// The environment of the service.
        /// </summary>
        /// <value>
        /// The environment of the service.
        /// </value>
        public string Environment { get; set; }

        /// <summary>
        /// MetaData about the service.
        /// </summary>
        /// <value>
        /// MetaData about the service.
        /// </value>
        public List<KeyValuePair<string, string>> MetaData { get; set; }

        #endregion

    }

}