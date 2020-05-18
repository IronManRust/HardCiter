using System;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using HardCiter.Service.Attributes;
using HardCiter.Service.Configuration;
using HardCiter.Service.Models;

namespace HardCiter.Service.Controllers
{

    /// <summary>
    /// The root controller from which all other controllers inherit.
    /// </summary>
    [ApiController]
    [SwaggerConsumes(MediaTypeNames.Application.Json)]
    [SwaggerProduces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ServiceException), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ServiceException), StatusCodes.Status500InternalServerError)]
    public abstract class RootController : ControllerBase
    {

        #region Constructors

        /// <summary>
        /// Initializes the controller.
        /// </summary>
        /// <param name="settings">
        /// Environment-specific settings.
        /// </param>
        /// <returns>
        /// An initialized controller.
        /// </returns>
        public RootController(IOptions<Settings> settings)
        {
            Settings = settings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Environment-specific settings.
        /// </summary>
        /// <value>
        /// Environment-specific settings.
        /// </value>
        protected IOptions<Settings> Settings { get; private set; }

        #endregion

    }

}