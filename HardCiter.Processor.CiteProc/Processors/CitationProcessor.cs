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

    public class CitationProcessor : BaseProcessor, DI.ICitationProcessor
    {

        #region Variables

        private PA.OverrideManager _overrideManager;

        #endregion

        #region Constructors

        public CitationProcessor(INodeServices nodeServices) : base(nodeServices)
        {
            _overrideManager = new PA.OverrideManager();
        }

        #endregion

        #region Properties

        protected override string JavaScriptFilename
        {
            get
            {
                return "CitationProcessor.js";
            }
        }

        #endregion

        #region Methods

        public List<KeyValuePair<string, string>> GetMetaData()
        {
            return GetMetaDataShared();
        }

        public DM.Citation CreateCitationBook(DE.Style style, DE.Format format, DM.Book book)
        {
            return CreateCitationAsync(style, format, book).Result;
        }

        public DM.Citation CreateCitationChapter(DE.Style style, DE.Format format, DM.Chapter chapter)
        {
            return CreateCitationAsync(style, format, chapter).Result;
        }

        public DM.Citation CreateCitationJournal(DE.Style style, DE.Format format, DM.Journal journal)
        {
            return CreateCitationAsync(style, format, journal).Result;
        }

        public DM.Citation CreateCitationMagazine(DE.Style style, DE.Format format, DM.Magazine magazine)
        {
            return CreateCitationAsync(style, format, magazine).Result;
        }

        public DM.Citation CreateCitationNewspaper(DE.Style style, DE.Format format, DM.Newspaper newspaper)
        {
            return CreateCitationAsync(style, format, newspaper).Result;
        }

        public DM.Citation CreateCitationWebpage(DE.Style style, DE.Format format, DM.Webpage webpage)
        {
            return CreateCitationAsync(style, format, webpage).Result;
        }

        public DM.Citation CreateCitationEncyclopedia(DE.Style style, DE.Format format, DM.Encyclopedia encyclopedia)
        {
            return CreateCitationAsync(style, format, encyclopedia).Result;
        }

        public DM.Citation CreateCitationGraphic(DE.Style style, DE.Format format, DM.Graphic graphic)
        {
            return CreateCitationAsync(style, format, graphic).Result;
        }

        public DM.Citation CreateCitationAudioRecording(DE.Style style, DE.Format format, DM.AudioRecording audioRecording)
        {
            return CreateCitationAsync(style, format, audioRecording).Result;
        }

        public DM.Citation CreateCitationVideoRecording(DE.Style style, DE.Format format, DM.VideoRecording videoRecording)
        {
            return CreateCitationAsync(style, format, videoRecording).Result;
        }

        public DM.Citation CreateCitationBroadcast(DE.Style style, DE.Format format, DM.Broadcast broadcast)
        {
            return CreateCitationAsync(style, format, broadcast).Result;
        }

        public DM.Citation CreateCitationPersonalCommunication(DE.Style style, DE.Format format, DM.PersonalCommunication personalCommunication)
        {
            return CreateCitationAsync(style, format, personalCommunication).Result;
        }

        public DM.Citation CreateCitationInterview(DE.Style style, DE.Format format, DM.Interview interview)
        {
            return CreateCitationAsync(style, format, interview).Result;
        }

        public DM.Citation CreateCitationPresentation(DE.Style style, DE.Format format, DM.Presentation presentation)
        {
            return CreateCitationAsync(style, format, presentation).Result;
        }

        public DM.Citation CreateCitationMap(DE.Style style, DE.Format format, DM.Map map)
        {
            return CreateCitationAsync(style, format, map).Result;
        }

        public DM.Citation CreateCitationBill(DE.Style style, DE.Format format, DM.Bill bill)
        {
            return CreateCitationAsync(style, format, bill).Result;
        }

        public DM.Citation CreateCitationLegislation(DE.Style style, DE.Format format, DM.Legislation legislation)
        {
            return CreateCitationAsync(style, format, legislation).Result;
        }

        public DM.Citation CreateCitationLegalCase(DE.Style style, DE.Format format, DM.LegalCase legalCase)
        {
            return CreateCitationAsync(style, format, legalCase).Result;
        }

        public DM.Citation CreateCitationReport(DE.Style style, DE.Format format, DM.Report report)
        {
            return CreateCitationAsync(style, format, report).Result;
        }

        public DM.Citation CreateCitationConferencePaper(DE.Style style, DE.Format format, DM.ConferencePaper conferencePaper)
        {
            return CreateCitationAsync(style, format, conferencePaper).Result;
        }

        private async Task<DM.Citation> CreateCitationAsync(DE.Style style, DE.Format format, DM.ContentItem contentItem)
        {
            ExpandoObject request = new ExpandoObject();
            List<PM.ContentItem> requestList = new List<PM.ContentItem>();
            requestList.Add(PF.CiteProcFactory.Build("0", contentItem));
            requestList = _overrideManager.PreProcessCitation(style, requestList);
            requestList.ForEach(x => request.TryAdd(x.ID, x));
            using (StringAsTempFile file = new StringAsTempFile(GetContents(), CancellationToken.None))
            {
                string result = await NodeServices.InvokeAsync<string>(file.FileName,
                                                                       GetLibrary(),
                                                                       PL.Locale.GetLocale(),
                                                                       PD.Definition.GetDefinition(style),
                                                                       PF.CiteProcFactory.Build(format),
                                                                       JObject.Parse(request.ToSerializedJSON()));
                PM.Citation citation = JsonConvert.DeserializeObject<PM.Citation>(result);
                citation.ProcessExceptions();
                citation = _overrideManager.PostProcessCitation(style, citation);
                DM.Citation response = PF.CiteProcFactory.Build(citation);
                return response;
            }
        }

        #endregion

    }

}