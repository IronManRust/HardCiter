using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.NodeServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HardCiter.Processor.CiteProc.Extensions;
using DE = HardCiter.Domain.Enums;
using DI = HardCiter.Domain.Interfaces;
using DM = HardCiter.Domain.Models;
using PD = HardCiter.Processor.CiteProc.Definitions;
using PF = HardCiter.Processor.CiteProc.Factories;
using PL = HardCiter.Processor.CiteProc.Locales;
using PA = HardCiter.Processor.CiteProc.Managers;
using PM = HardCiter.Processor.CiteProc.Models;

namespace HardCiter.Processor.CiteProc.Processors
{

    public class BibliographyProcessor : BaseProcessor, DI.IBibliographyProcessor
    {

        #region Variables

        private PA.OverrideManager _overrideManager;

        #endregion

        #region Constructors

        public BibliographyProcessor(INodeServices nodeServices) : base(nodeServices)
        {
            _overrideManager = new PA.OverrideManager();
        }

        #endregion

        #region Properties

        protected override string JavaScriptFilename
        {
            get
            {
                return "BibliographyProcessor.js";
            }
        }

        #endregion

        #region Methods

        public List<KeyValuePair<string, string>> GetMetaData()
        {
            return GetMetaDataShared();
        }

        public DM.Bibliography CreateBibliography(DE.Style style, DE.Format format, List<DM.ContentItem> contentItems)
        {
            return CreateBibliographyAsync(style, format, contentItems).Result;
        }

        private async Task<DM.Bibliography> CreateBibliographyAsync(DE.Style style, DE.Format format, List<DM.ContentItem> contentItems)
        {
            ExpandoObject request = new ExpandoObject();
            List<PM.ContentItem> requestList = new List<PM.ContentItem>();
            requestList.AddRange(contentItems.Select((x, i) => PF.CiteProcFactory.Build(i.ToString(), x)));
            requestList = _overrideManager.PreProcessBibliography(style, requestList);
            requestList.ForEach(x => request.TryAdd(x.ID, x));
            using (StringAsTempFile file = new StringAsTempFile(GetContents(), CancellationToken.None))
            {
                string result = await NodeServices.InvokeAsync<string>(file.FileName,
                                                                       GetLibrary(),
                                                                       PL.Locale.GetLocale(),
                                                                       PD.Definition.GetDefinition(style),
                                                                       PF.CiteProcFactory.Build(format),
                                                                       JObject.Parse(request.ToSerializedJSON()));
                PM.Bibliography bibliography = JsonConvert.DeserializeObject<PM.Bibliography>(result);
                bibliography.ProcessExceptions();
                bibliography = _overrideManager.PostProcessBibliography(style, bibliography);
                DM.Bibliography response = PF.CiteProcFactory.Build(bibliography);
                return response;
            }
        }

        #endregion

    }

}