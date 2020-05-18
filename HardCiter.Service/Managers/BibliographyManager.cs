using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.NodeServices;
using HardCiter.API;
using HardCiter.Service.Factories;
using DE = HardCiter.Domain.Enums;
using DM = HardCiter.Domain.Models;
using SE = HardCiter.Service.Enums;
using SM = HardCiter.Service.Models;

namespace HardCiter.Service.Managers
{

    internal class BibliographyManager : RootManager
    {

        #region Variables

        private BibliographyProcessor _bibliographyProcessor;

        #endregion

        #region Constructors

        internal BibliographyManager(INodeServices nodeServices)
        {
            _bibliographyProcessor = GetBibliographyProcessor(nodeServices);
        }

        #endregion

        #region Methods

        internal SM.Bibliography CreateBibliography(SE.Style style, SE.Format format, List<SM.ContentItem> contentItems)
        {
            return ContentItemFactory.Build(_bibliographyProcessor.CreateBibliography(ContentItemFactory.Build(style),
                                                                                      ContentItemFactory.Build(format),
                                                                                      contentItems != null ? contentItems.Select(x => ContentItemFactory.Build(x))
                                                                                                                         .ToList()
                                                                                                           : new List<DM.ContentItem>()));
        }

        #endregion

    }

}