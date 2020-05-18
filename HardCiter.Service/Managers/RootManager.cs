using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.NodeServices;
using HardCiter.API;
using DI = HardCiter.Domain.Interfaces;
using DM = HardCiter.Domain.Models;
using DR = HardCiter.Domain.Rules;
using CP = HardCiter.Processor.CiteProc.Processors;

namespace HardCiter.Service.Managers
{

    /// <summary>
    /// Abstract manager foundation.
    /// </summary>
    /// <remarks>
    /// Since this service is only supplied by one possible processor implementation, this manager takes shortcuts with configuration-based dependency injection.
    /// </remarks>
    internal abstract class RootManager
    {

        #region Variables

        private List<DI.IRule<DM.Book>> _rulesBook;
        private List<DI.IRule<DM.Chapter>> _rulesChapter;
        private List<DI.IRule<DM.Journal>> _rulesJournal;
        private List<DI.IRule<DM.Magazine>> _rulesMagazine;
        private List<DI.IRule<DM.Newspaper>> _rulesNewspaper;
        private List<DI.IRule<DM.Webpage>> _rulesWebpage;
        private List<DI.IRule<DM.Encyclopedia>> _rulesEncyclopedia;
        private List<DI.IRule<DM.Graphic>> _rulesGraphic;
        private List<DI.IRule<DM.AudioRecording>> _rulesAudioRecording;
        private List<DI.IRule<DM.VideoRecording>> _rulesVideoRecording;
        private List<DI.IRule<DM.Broadcast>> _rulesBroadcast;
        private List<DI.IRule<DM.PersonalCommunication>> _rulesPersonalCommunication;
        private List<DI.IRule<DM.Interview>> _rulesInterview;
        private List<DI.IRule<DM.Presentation>> _rulesPresentation;
        private List<DI.IRule<DM.Map>> _rulesMap;
        private List<DI.IRule<DM.Bill>> _rulesBill;
        private List<DI.IRule<DM.Legislation>> _rulesLegislation;
        private List<DI.IRule<DM.LegalCase>> _rulesLegalCase;
        private List<DI.IRule<DM.Report>> _rulesReport;
        private List<DI.IRule<DM.ConferencePaper>> _rulesConferencePaper;

        #endregion

        #region Constructors

        internal RootManager()
        {
            _rulesBook = new List<DI.IRule<DM.Book>>();
            _rulesBook.Add(new DR.CreatorIsValid());
            _rulesBook.Add(new DR.DateInformationIsValid());

            _rulesChapter = new List<DI.IRule<DM.Chapter>>();
            _rulesChapter.Add(new DR.CreatorIsValid());
            _rulesChapter.Add(new DR.DateInformationIsValid());

            _rulesJournal = new List<DI.IRule<DM.Journal>>();
            _rulesJournal.Add(new DR.CreatorIsValid());
            _rulesJournal.Add(new DR.DateInformationIsValid());

            _rulesMagazine = new List<DI.IRule<DM.Magazine>>();
            _rulesMagazine.Add(new DR.CreatorIsValid());
            _rulesMagazine.Add(new DR.DateInformationIsValid());

            _rulesNewspaper = new List<DI.IRule<DM.Newspaper>>();
            _rulesNewspaper.Add(new DR.CreatorIsValid());
            _rulesNewspaper.Add(new DR.DateInformationIsValid());

            _rulesWebpage = new List<DI.IRule<DM.Webpage>>();
            _rulesWebpage.Add(new DR.CreatorIsValid());
            _rulesWebpage.Add(new DR.DateInformationIsValid());

            _rulesEncyclopedia = new List<DI.IRule<DM.Encyclopedia>>();
            _rulesEncyclopedia.Add(new DR.CreatorIsValid());
            _rulesEncyclopedia.Add(new DR.DateInformationIsValid());

            _rulesGraphic = new List<DI.IRule<DM.Graphic>>();
            _rulesGraphic.Add(new DR.CreatorIsValid());
            _rulesGraphic.Add(new DR.DateInformationIsValid());

            _rulesAudioRecording = new List<DI.IRule<DM.AudioRecording>>();
            _rulesAudioRecording.Add(new DR.CreatorIsValid());
            _rulesAudioRecording.Add(new DR.DateInformationIsValid());

            _rulesVideoRecording = new List<DI.IRule<DM.VideoRecording>>();
            _rulesVideoRecording.Add(new DR.CreatorIsValid());
            _rulesVideoRecording.Add(new DR.DateInformationIsValid());

            _rulesBroadcast = new List<DI.IRule<DM.Broadcast>>();
            _rulesBroadcast.Add(new DR.CreatorIsValid());
            _rulesBroadcast.Add(new DR.DateInformationIsValid());

            _rulesPersonalCommunication = new List<DI.IRule<DM.PersonalCommunication>>();
            _rulesPersonalCommunication.Add(new DR.CreatorIsValid());
            _rulesPersonalCommunication.Add(new DR.DateInformationIsValid());

            _rulesInterview = new List<DI.IRule<DM.Interview>>();
            _rulesInterview.Add(new DR.CreatorIsValid());
            _rulesInterview.Add(new DR.DateInformationIsValid());

            _rulesPresentation = new List<DI.IRule<DM.Presentation>>();
            _rulesPresentation.Add(new DR.CreatorIsValid());
            _rulesPresentation.Add(new DR.DateInformationIsValid());

            _rulesMap = new List<DI.IRule<DM.Map>>();
            _rulesMap.Add(new DR.CreatorIsValid());
            _rulesMap.Add(new DR.DateInformationIsValid());

            _rulesBill = new List<DI.IRule<DM.Bill>>();
            _rulesBill.Add(new DR.CreatorIsValid());
            _rulesBill.Add(new DR.DateInformationIsValid());

            _rulesLegislation = new List<DI.IRule<DM.Legislation>>();
            _rulesLegislation.Add(new DR.CreatorIsValid());
            _rulesLegislation.Add(new DR.DateInformationIsValid());

            _rulesLegalCase = new List<DI.IRule<DM.LegalCase>>();
            _rulesLegalCase.Add(new DR.CreatorIsValid());
            _rulesLegalCase.Add(new DR.DateInformationIsValid());

            _rulesReport = new List<DI.IRule<DM.Report>>();
            _rulesReport.Add(new DR.CreatorIsValid());
            _rulesReport.Add(new DR.DateInformationIsValid());

            _rulesConferencePaper = new List<DI.IRule<DM.ConferencePaper>>();
            _rulesConferencePaper.Add(new DR.CreatorIsValid());
            _rulesConferencePaper.Add(new DR.DateInformationIsValid());
        }

        #endregion

        #region Methods

        protected BibliographyProcessor GetBibliographyProcessor(INodeServices nodeServices)
        {
            return new BibliographyProcessor(new CP.BibliographyProcessor(nodeServices),
                                             _rulesBook,
                                             _rulesChapter,
                                             _rulesJournal,
                                             _rulesMagazine,
                                             _rulesNewspaper,
                                             _rulesWebpage,
                                             _rulesEncyclopedia,
                                             _rulesGraphic,
                                             _rulesAudioRecording,
                                             _rulesVideoRecording,
                                             _rulesBroadcast,
                                             _rulesPersonalCommunication,
                                             _rulesInterview,
                                             _rulesPresentation,
                                             _rulesMap,
                                             _rulesBill,
                                             _rulesLegislation,
                                             _rulesLegalCase,
                                             _rulesReport,
                                             _rulesConferencePaper);
        }

        protected CitationProcessor GetCitationProcessor(INodeServices nodeServices)
        {
            return new CitationProcessor(new CP.CitationProcessor(nodeServices),
                                         _rulesBook,
                                         _rulesChapter,
                                         _rulesJournal,
                                         _rulesMagazine,
                                         _rulesNewspaper,
                                         _rulesWebpage,
                                         _rulesEncyclopedia,
                                         _rulesGraphic,
                                         _rulesAudioRecording,
                                         _rulesVideoRecording,
                                         _rulesBroadcast,
                                         _rulesPersonalCommunication,
                                         _rulesInterview,
                                         _rulesPresentation,
                                         _rulesMap,
                                         _rulesBill,
                                         _rulesLegislation,
                                         _rulesLegalCase,
                                         _rulesReport,
                                         _rulesConferencePaper);
        }

        #endregion

    }

}