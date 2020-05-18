using System;
using Swashbuckle.AspNetCore.Swagger;

namespace HardCiter.Service.Configuration
{

    /// <summary>
    /// Describes the service's settings, both hard-coded and config-driven.
    /// </summary>
    public class Settings
    {

        #region Properties

        /// <summary>
        /// The title of the service.
        /// </summary>
        /// <value>
        /// The title of the service.
        /// </value>
        public static string Title
        {
            get
            {
                return "HardCiter Service";
            }
        }

        /// <summary>
        /// The version of the service.
        /// </summary>
        /// <value>
        /// The version of the service.
        /// </value>
        public static string Version
        {
            get
            {
                return "1.0";
            }
        }

        /// <summary>
        /// The name of the service.
        /// </summary>
        /// <value>
        /// The name of the service.
        /// </value>
        public static string Name
        {
            get
            {
                return $"{Title} v{Version}";
            }
        }

        /// <summary>
        /// The services's JSON schema.
        /// </summary>
        /// <value>
        /// The services's JSON schema.
        /// </value>
        public static string Schema
        {
            get
            {
                return $"/swagger/{Version}/swagger.json";
            }
        }

        /// <summary>
        /// The environment of the service.
        /// </summary>
        /// <value>
        /// The environment of the service.
        /// </value>
        public string Environment { get; set; }

        /// <summary>
        /// A flag indicating if unhandled exception details are shown.
        /// </summary>
        /// <value>
        /// A flag indicating if unhandled exception details are shown.
        /// </value>
        public bool ShowUnhandledExceptionDetails { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Converts the service's settings into a Swagger Info object.
        /// </summary>
        /// <returns>
        /// A Swagger Info object.
        /// </returns>
        public static Info ToInfo()
        {
            return new Info()
            {
                Title = Title,
                Version = Version,
                Description = "This service provides bibliographic and citation information in various styles.",
                TermsOfService = "#",
                Contact = new Contact()
                {
                    Name = "Shawn Headrick",
                    Url = "https://github.com/IronManRust",
                    Email = "shawn_headrick@yahoo.com"
                },
                License = new License()
                {
                    Name = "MIT License",
                    Url = "https://www.opensource.org/licenses/MIT"
                }
            };
        }

        #endregion

    }

}