using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.Extensions.Options;
using HardCiter.Service.Configuration;
using HardCiter.Service.Managers;
using SE = HardCiter.Service.Enums;
using SM = HardCiter.Service.Models;

namespace HardCiter.Service.Controllers
{

    /// <summary>
    /// Handles bibliography generation.
    /// </summary>
    [ApiController]
    public class BibliographyController : RootController
    {

        #region Variables

        private BibliographyManager _bibliographyManager;

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
        public BibliographyController(IOptions<Settings> settings, INodeServices nodeServices) : base(settings)
        {
            _bibliographyManager = new BibliographyManager(nodeServices);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Generates a bibliography.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="contentItems">
        /// A list of items making up the bibliography.
        /// </param>
        /// <returns>
        /// A bibliography.
        /// </returns>
        [HttpPost]
        [Route(Routes.Bibliography)]
        public SM.Bibliography Bibliography(SE.Style style, SE.Format format, [FromBody]List<SM.ContentItem> contentItems)
        {
            return _bibliographyManager.CreateBibliography(style, format, contentItems);
        }

        #endregion

    }

}