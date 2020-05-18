using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using HardCiter.Service.Configuration;
using HardCiter.Service.Models;

namespace HardCiter.Service.Middleware
{

    /// <summary>
    /// Handles turning exceptions into typed HTTP responses.
    /// </summary>
    public class ErrorHandlingMiddleware
    {

        #region Variables

        private readonly RequestDelegate _requestDelegate;
        private readonly IOptions<Settings> _settings;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an object that handles turning exceptions into typed HTTP responses.
        /// </summary>
        /// <param name="requestDelegate">
        /// A function that can process an HTTP request.
        /// </param>
        /// <param name="settings">
        /// Environment-specific settings.
        /// </param>
        /// <param name="logger">
        /// Message logger.
        /// </param>
        public ErrorHandlingMiddleware(RequestDelegate requestDelegate, IOptions<Settings> settings, ILogger<ErrorHandlingMiddleware> logger)
        {
            _requestDelegate = requestDelegate;
            _settings = settings;
            _logger = logger;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Handles turning exceptions into typed HTTP responses.
        /// </summary>
        /// <param name="httpContext">
        /// Encapsulates all HTTP-specific information about an individual HTTP request.
        /// </param>
        /// <returns>
        /// A typed HTTP responses.
        /// </returns>
        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _requestDelegate(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            try
            {
                LogException(exception);
            }
            catch
            {
                // If the exception logging fails, that's bad, but continue on anyway.
            }

            ServiceException serviceException = new ServiceException(GetExceptionCode(exception),
                                                                     GetExceptionMessage(exception));

            httpContext.Response.StatusCode = serviceException.StatusCode;
            httpContext.Response.ContentType = ServiceException.ContentType;

            return httpContext.Response.WriteAsync(serviceException.ToString());
        }

        private void LogException(Exception exception)
        {
            if (exception != null)
            {
                if (exception is AggregateException)
                {
                    (exception as AggregateException).InnerExceptions.ToList().ForEach(x => LogException(x));
                }
                else
                {
                    if (exception is ArgumentException ||
                        exception is ArgumentNullException ||
                        exception is ArgumentOutOfRangeException)
                    {
                        _logger.LogDebug(exception, "The request contained invalid data.");
                    }
                    else
                    {
                        _logger.LogError(exception, "There was an error while processing the request.");
                    }
                }
            }
        }

        private static HttpStatusCode GetExceptionCode(Exception exception)
        {
            if ((exception is ArgumentException) ||
                (exception is ArgumentNullException) ||
                (exception is ArgumentOutOfRangeException) ||
                (exception is AggregateException && (exception as AggregateException).InnerExceptions.Where(x => x != null)
                                                                                                     .Any()
                                                 && (exception as AggregateException).InnerExceptions.Where(x => x != null)
                                                                                                     .All(x => x is ArgumentException
                                                                                                            || x is ArgumentNullException
                                                                                                            || x is ArgumentOutOfRangeException)))
            {
                return HttpStatusCode.BadRequest;
            }
            else
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        private string GetExceptionMessage(Exception exception)
        {
            List<string> messages = GetExceptionMessages(exception);
            switch (messages.Count)
            {
                case 0:
                    return "Something Went Wrong";
                case 1:
                    return messages.First();
                default:
                    return string.Format("Multiple Errors - ({0})", string.Join(" | ", messages));
            }
        }

        private List<string> GetExceptionMessages(Exception exception)
        {
            List<string> messages = new List<string>();
            if (exception != null)
            {
                if (exception is ArgumentException ||
                    exception is ArgumentNullException ||
                    exception is ArgumentOutOfRangeException)
                {
                    messages.Add(exception.Message.Replace(Environment.NewLine, " "));
                }
                else if (exception is AggregateException)
                {
                    messages.AddRange((exception as AggregateException).InnerExceptions.SelectMany(x => GetExceptionMessages(x)));
                }
                else
                {
                    if (_settings.Value.ShowUnhandledExceptionDetails)
                    {
                        messages.Add(exception.Message.Replace(Environment.NewLine, " "));
                    }
                    else
                    {
                        messages.Add("Something Went Wrong");
                    }
                }
            }
            return messages;
        }

        #endregion

    }

}