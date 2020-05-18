using System;
using System.Net;
using System.Net.Mime;
using Newtonsoft.Json;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// Describes a service exception.
    /// </summary>
    public class ServiceException
    {

        #region Constructors

        /// <summary>
        /// Initializes the service exception object.
        /// </summary>
        /// <param name="httpStatusCode">
        /// The HTTP status code.
        /// </param>
        /// <param name="message">
        /// The exception message.
        /// </param>
        public ServiceException(HttpStatusCode httpStatusCode, string message)
        {
            Code = httpStatusCode;
            Message = message;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        /// <value>
        /// The HTTP status code.
        /// </value>
        public HttpStatusCode Code { get; private set; }

        /// <summary>
        /// The HTTP status.
        /// </summary>
        /// <value>
        /// The HTTP status.
        /// </value>
        public string Status
        {
            get
            {
                return Code.ToString();
            }
        }

        /// <summary>
        /// The exception message.
        /// </summary>
        /// <value>
        /// The exception message.
        /// </value>
        public string Message { get; private set; }

        internal int StatusCode
        {
            get
            {
                return (int)Code;
            }
        }

        internal static string ContentType
        {
            get
            {
                return MediaTypeNames.Application.Json;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The service exception information in JSON format.
        /// </summary>
        /// <returns>
        /// The service exception information in JSON format.
        /// </returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        #endregion

    }

}