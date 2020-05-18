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
    /// Handles in-line citation generation.
    /// </summary>
    [ApiController]
    public class CitationController : RootController
    {

        #region Variables

        private CitationManager _citationManager;

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
        public CitationController(IOptions<Settings> settings, INodeServices nodeServices) : base(settings)
        {
            _citationManager = new CitationManager(nodeServices);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Generates an in-line book citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="book">
        /// Information about the book.
        /// </param>
        /// <returns>
        /// An in-line book citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationBook)]
        public SM.Citation Book(SE.Style style, SE.Format format, [FromBody]SM.Book book)
        {
            return _citationManager.CreateCitationBook(style, format, book);
        }

        /// <summary>
        /// Generates an in-line chapter citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="chapter">
        /// Information about the chapter.
        /// </param>
        /// <returns>
        /// An in-line chapter citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationChapter)]
        public SM.Citation Chapter(SE.Style style, SE.Format format, [FromBody]SM.Chapter chapter)
        {
            return _citationManager.CreateCitationChapter(style, format, chapter);
        }

        /// <summary>
        /// Generates an in-line journal citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="journal">
        /// Information about the journal.
        /// </param>
        /// <returns>
        /// An in-line journal citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationJournal)]
        public SM.Citation Journal(SE.Style style, SE.Format format, [FromBody]SM.Journal journal)
        {
            return _citationManager.CreateCitationJournal(style, format, journal);
        }

        /// <summary>
        /// Generates an in-line magazine citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="magazine">
        /// Information about the magazine.
        /// </param>
        /// <returns>
        /// An in-line magazine citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationMagazine)]
        public SM.Citation Magazine(SE.Style style, SE.Format format, [FromBody]SM.Magazine magazine)
        {
            return _citationManager.CreateCitationMagazine(style, format, magazine);
        }

        /// <summary>
        /// Generates an in-line newspaper citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="newspaper">
        /// Information about the newspaper.
        /// </param>
        /// <returns>
        /// An in-line newspaper citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationNewspaper)]
        public SM.Citation Newspaper(SE.Style style, SE.Format format, [FromBody]SM.Newspaper newspaper)
        {
            return _citationManager.CreateCitationNewspaper(style, format, newspaper);
        }

        /// <summary>
        /// Generates an in-line webpage citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="webpage">
        /// Information about the webpage.
        /// </param>
        /// <returns>
        /// An in-line webpage citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationWebpage)]
        public SM.Citation Webpage(SE.Style style, SE.Format format, [FromBody]SM.Webpage webpage)
        {
            return _citationManager.CreateCitationWebpage(style, format, webpage);
        }

        /// <summary>
        /// Generates an in-line encyclopedia citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="encyclopedia">
        /// Information about the encyclopedia.
        /// </param>
        /// <returns>
        /// An in-line encyclopedia citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationEncyclopedia)]
        public SM.Citation Encyclopedia(SE.Style style, SE.Format format, [FromBody]SM.Encyclopedia encyclopedia)
        {
            return _citationManager.CreateCitationEncyclopedia(style, format, encyclopedia);
        }

        /// <summary>
        /// Generates an in-line graphic citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="graphic">
        /// Information about the graphic.
        /// </param>
        /// <returns>
        /// An in-line graphic citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationGraphic)]
        public SM.Citation Graphic(SE.Style style, SE.Format format, [FromBody]SM.Graphic graphic)
        {
            return _citationManager.CreateCitationGraphic(style, format, graphic);
        }

        /// <summary>
        /// Generates an in-line audio recording citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="audioRecording">
        /// Information about the audio recording.
        /// </param>
        /// <returns>
        /// An in-line audio recording citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationAudioRecording)]
        public SM.Citation AudioRecording(SE.Style style, SE.Format format, [FromBody]SM.AudioRecording audioRecording)
        {
            return _citationManager.CreateCitationAudioRecording(style, format, audioRecording);
        }

        /// <summary>
        /// Generates an in-line video recording citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="videoRecording">
        /// Information about the video recording.
        /// </param>
        /// <returns>
        /// An in-line video recording citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationVideoRecording)]
        public SM.Citation VideoRecording(SE.Style style, SE.Format format, [FromBody]SM.VideoRecording videoRecording)
        {
            return _citationManager.CreateCitationVideoRecording(style, format, videoRecording);
        }

        /// <summary>
        /// Generates an in-line broadcast citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="broadcast">
        /// Information about the broadcast.
        /// </param>
        /// <returns>
        /// An in-line broadcast citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationBroadcast)]
        public SM.Citation Broadcast(SE.Style style, SE.Format format, [FromBody]SM.Broadcast broadcast)
        {
            return _citationManager.CreateCitationBroadcast(style, format, broadcast);
        }

        /// <summary>
        /// Generates an in-line personal communication citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="personalCommunication">
        /// Information about the personal communication.
        /// </param>
        /// <returns>
        /// An in-line personal communication citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationPersonalCommunication)]
        public SM.Citation PersonalCommunication(SE.Style style, SE.Format format, [FromBody]SM.PersonalCommunication personalCommunication)
        {
            return _citationManager.CreateCitationPersonalCommunication(style, format, personalCommunication);
        }

        /// <summary>
        /// Generates an in-line interview citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="interview">
        /// Information about the interview.
        /// </param>
        /// <returns>
        /// An in-line interview citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationInterview)]
        public SM.Citation Interview(SE.Style style, SE.Format format, [FromBody]SM.Interview interview)
        {
            return _citationManager.CreateCitationInterview(style, format, interview);
        }

        /// <summary>
        /// Generates an in-line presentation citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="presentation">
        /// Information about the presentation.
        /// </param>
        /// <returns>
        /// An in-line presentation citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationPresentation)]
        public SM.Citation Presentation(SE.Style style, SE.Format format, [FromBody]SM.Presentation presentation)
        {
            return _citationManager.CreateCitationPresentation(style, format, presentation);
        }

        /// <summary>
        /// Generates an in-line map citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="map">
        /// Information about the map.
        /// </param>
        /// <returns>
        /// An in-line map citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationMap)]
        public SM.Citation Map(SE.Style style, SE.Format format, [FromBody]SM.Map map)
        {
            return _citationManager.CreateCitationMap(style, format, map);
        }

        /// <summary>
        /// Generates an in-line bill citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="bill">
        /// Information about the bill.
        /// </param>
        /// <returns>
        /// An in-line bill citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationBill)]
        public SM.Citation Bill(SE.Style style, SE.Format format, [FromBody]SM.Bill bill)
        {
            return _citationManager.CreateCitationBill(style, format, bill);
        }

        /// <summary>
        /// Generates an in-line legislation citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="legislation">
        /// Information about the legislation.
        /// </param>
        /// <returns>
        /// An in-line legislation citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationLegislation)]
        public SM.Citation Legislation(SE.Style style, SE.Format format, [FromBody]SM.Legislation legislation)
        {
            return _citationManager.CreateCitationLegislation(style, format, legislation);
        }

        /// <summary>
        /// Generates an in-line legal case citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="legalCase">
        /// Information about the legal case.
        /// </param>
        /// <returns>
        /// An in-line legal case citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationLegalCase)]
        public SM.Citation LegalCase(SE.Style style, SE.Format format, [FromBody]SM.LegalCase legalCase)
        {
            return _citationManager.CreateCitationLegalCase(style, format, legalCase);
        }

        /// <summary>
        /// Generates an in-line report citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="report">
        /// Information about the report.
        /// </param>
        /// <returns>
        /// An in-line report citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationReport)]
        public SM.Citation Report(SE.Style style, SE.Format format, [FromBody]SM.Report report)
        {
            return _citationManager.CreateCitationReport(style, format, report);
        }

        /// <summary>
        /// Generates an in-line conference paper citation.
        /// </summary>
        /// <param name="style">
        /// The citation style.
        /// </param>
        /// <param name="format">
        /// The output format.
        /// </param>
        /// <param name="conferencePaper">
        /// Information about the conference paper.
        /// </param>
        /// <returns>
        /// An in-line conference paper citation.
        /// </returns>
        [HttpPost]
        [Route(Routes.CitationConferencePaper)]
        public SM.Citation ConferencePaper(SE.Style style, SE.Format format, [FromBody]SM.ConferencePaper conferencePaper)
        {
            return _citationManager.CreateCitationConferencePaper(style, format, conferencePaper);
        }

        #endregion

    }

}