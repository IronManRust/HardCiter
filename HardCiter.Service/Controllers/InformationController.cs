using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.Extensions.Options;
using HardCiter.Service.Configuration;
using HardCiter.Service.Managers;
using HardCiter.Service.Models;

namespace HardCiter.Service.Controllers
{

    /// <summary>
    /// Handles service information actions.
    /// </summary>
    [ApiController]
    public class InformationController : RootController
    {

        #region Variables

        private InformationManager _informationManager;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the controller.
        /// </summary>
        /// <param name="settings">
        /// Environment-specific settings.
        /// </param>
        /// <param name="nodeServices">
        /// Node.JS services.
        /// </param>
        /// <returns>
        /// An initialized controller.
        /// </returns>
        public InformationController(IOptions<Settings> settings, INodeServices nodeServices) : base(settings)
        {
            _informationManager = new InformationManager(settings, nodeServices);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the status of the service.
        /// </summary>
        /// <returns>
        /// The status of the service.
        /// </returns>
        [HttpGet]
        [Route(Routes.Status)]
        public Status Status()
        {
            return _informationManager.GetStatus();
        }

        #endregion

    }

}