using System;
using System.Collections.Generic;
using System.Linq;
using DE = HardCiter.Domain.Enums;
using DI = HardCiter.Domain.Interfaces;
using DM = HardCiter.Domain.Models;

namespace HardCiter.API
{

    public class CitationProcessor : BaseProcessor
    {

        #region Variables

        private DI.ICitationProcessor _citationProcessor;

        #endregion

        #region Constructors

        public CitationProcessor(DI.ICitationProcessor citationProcessor, IEnumerable<DI.IRule<DM.Book>> rulesBook, IEnumerable<DI.IRule<DM.Chapter>> rulesChapter, IEnumerable<DI.IRule<DM.Journal>> rulesJournal, IEnumerable<DI.IRule<DM.Magazine>> rulesMagazine, IEnumerable<DI.IRule<DM.Newspaper>> rulesNewspaper, IEnumerable<DI.IRule<DM.Webpage>> rulesWebpage, IEnumerable<DI.IRule<DM.Encyclopedia>> rulesEncyclopedia, IEnumerable<DI.IRule<DM.Graphic>> rulesGraphic, IEnumerable<DI.IRule<DM.AudioRecording>> rulesAudioRecording, IEnumerable<DI.IRule<DM.VideoRecording>> rulesVideoRecording, IEnumerable<DI.IRule<DM.Broadcast>> rulesBroadcast, IEnumerable<DI.IRule<DM.PersonalCommunication>> rulesPersonalCommunication, IEnumerable<DI.IRule<DM.Interview>> rulesInterview, IEnumerable<DI.IRule<DM.Presentation>> rulesPresentation, IEnumerable<DI.IRule<DM.Map>> rulesMap, IEnumerable<DI.IRule<DM.Bill>> rulesBill, IEnumerable<DI.IRule<DM.Legislation>> rulesLegislation, IEnumerable<DI.IRule<DM.LegalCase>> rulesLegalCase, IEnumerable<DI.IRule<DM.Report>> rulesReport, IEnumerable<DI.IRule<DM.ConferencePaper>> rulesConferencePaper) : base(rulesBook, rulesChapter, rulesJournal, rulesMagazine, rulesNewspaper, rulesWebpage, rulesEncyclopedia, rulesGraphic, rulesAudioRecording, rulesVideoRecording, rulesBroadcast, rulesPersonalCommunication, rulesInterview, rulesPresentation, rulesMap, rulesBill, rulesLegislation, rulesLegalCase, rulesReport, rulesConferencePaper)
        {
            _citationProcessor = citationProcessor;
        }

        #endregion

        #region Methods

        public List<KeyValuePair<string, string>> GetMetaData()
        {
            return _citationProcessor.GetMetaData();
        }

        public DM.Citation CreateCitationBook(DE.Style style, DE.Format format, DM.Book book)
        {
            return _citationProcessor.CreateCitationBook(style, format, RuleManagerBook.Validate(book));
        }

        public DM.Citation CreateCitationChapter(DE.Style style, DE.Format format, DM.Chapter chapter)
        {
            return _citationProcessor.CreateCitationChapter(style, format, RuleManagerChapter.Validate(chapter));
        }

        public DM.Citation CreateCitationJournal(DE.Style style, DE.Format format, DM.Journal journal)
        {
            return _citationProcessor.CreateCitationJournal(style, format, RuleManagerJournal.Validate(journal));
        }

        public DM.Citation CreateCitationMagazine(DE.Style style, DE.Format format, DM.Magazine magazine)
        {
            return _citationProcessor.CreateCitationMagazine(style, format, RuleManagerMagazine.Validate(magazine));
        }

        public DM.Citation CreateCitationNewspaper(DE.Style style, DE.Format format, DM.Newspaper newspaper)
        {
            return _citationProcessor.CreateCitationNewspaper(style, format, RuleManagerNewspaper.Validate(newspaper));
        }

        public DM.Citation CreateCitationWebpage(DE.Style style, DE.Format format, DM.Webpage webpage)
        {
            return _citationProcessor.CreateCitationWebpage(style, format, RuleManagerWebpage.Validate(webpage));
        }

        public DM.Citation CreateCitationEncyclopedia(DE.Style style, DE.Format format, DM.Encyclopedia encyclopedia)
        {
            return _citationProcessor.CreateCitationEncyclopedia(style, format, RuleManagerEncyclopedia.Validate(encyclopedia));
        }

        public DM.Citation CreateCitationGraphic(DE.Style style, DE.Format format, DM.Graphic graphic)
        {
            return _citationProcessor.CreateCitationGraphic(style, format, RuleManagerGraphic.Validate(graphic));
        }

        public DM.Citation CreateCitationAudioRecording(DE.Style style, DE.Format format, DM.AudioRecording audioRecording)
        {
            return _citationProcessor.CreateCitationAudioRecording(style, format, RuleManagerAudioRecording.Validate(audioRecording));
        }

        public DM.Citation CreateCitationVideoRecording(DE.Style style, DE.Format format, DM.VideoRecording videoRecording)
        {
            return _citationProcessor.CreateCitationVideoRecording(style, format, RuleManagerVideoRecording.Validate(videoRecording));
        }

        public DM.Citation CreateCitationBroadcast(DE.Style style, DE.Format format, DM.Broadcast broadcast)
        {
            return _citationProcessor.CreateCitationBroadcast(style, format, RuleManagerBroadcast.Validate(broadcast));
        }

        public DM.Citation CreateCitationPersonalCommunication(DE.Style style, DE.Format format, DM.PersonalCommunication personalCommunication)
        {
            return _citationProcessor.CreateCitationPersonalCommunication(style, format, RuleManagerPersonalCommunication.Validate(personalCommunication));
        }

        public DM.Citation CreateCitationInterview(DE.Style style, DE.Format format, DM.Interview interview)
        {
            return _citationProcessor.CreateCitationInterview(style, format, RuleManagerInterview.Validate(interview));
        }

        public DM.Citation CreateCitationPresentation(DE.Style style, DE.Format format, DM.Presentation presentation)
        {
            return _citationProcessor.CreateCitationPresentation(style, format, RuleManagerPresentation.Validate(presentation));
        }

        public DM.Citation CreateCitationMap(DE.Style style, DE.Format format, DM.Map map)
        {
            return _citationProcessor.CreateCitationMap(style, format, RuleManagerMap.Validate(map));
        }

        public DM.Citation CreateCitationBill(DE.Style style, DE.Format format, DM.Bill bill)
        {
            return _citationProcessor.CreateCitationBill(style, format, RuleManagerBill.Validate(bill));
        }

        public DM.Citation CreateCitationLegislation(DE.Style style, DE.Format format, DM.Legislation legislation)
        {
            return _citationProcessor.CreateCitationLegislation(style, format, RuleManagerLegislation.Validate(legislation));
        }

        public DM.Citation CreateCitationLegalCase(DE.Style style, DE.Format format, DM.LegalCase legalCase)
        {
            return _citationProcessor.CreateCitationLegalCase(style, format, RuleManagerLegalCase.Validate(legalCase));
        }

        public DM.Citation CreateCitationReport(DE.Style style, DE.Format format, DM.Report report)
        {
            return _citationProcessor.CreateCitationReport(style, format, RuleManagerReport.Validate(report));
        }

        public DM.Citation CreateCitationConferencePaper(DE.Style style, DE.Format format, DM.ConferencePaper conferencePaper)
        {
            return _citationProcessor.CreateCitationConferencePaper(style, format, RuleManagerConferencePaper.Validate(conferencePaper));
        }

        #endregion

    }

}