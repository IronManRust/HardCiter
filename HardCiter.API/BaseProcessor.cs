using System;
using System.Collections.Generic;
using System.Linq;
using DE = HardCiter.Domain.Enums;
using DI = HardCiter.Domain.Interfaces;
using DG = HardCiter.Domain.Managers;
using DM = HardCiter.Domain.Models;

namespace HardCiter.API
{

    public abstract class BaseProcessor
    {

        #region Constructors

        public BaseProcessor(IEnumerable<DI.IRule<DM.Book>> rulesBook, IEnumerable<DI.IRule<DM.Chapter>> rulesChapter, IEnumerable<DI.IRule<DM.Journal>> rulesJournal, IEnumerable<DI.IRule<DM.Magazine>> rulesMagazine, IEnumerable<DI.IRule<DM.Newspaper>> rulesNewspaper, IEnumerable<DI.IRule<DM.Webpage>> rulesWebpage, IEnumerable<DI.IRule<DM.Encyclopedia>> rulesEncyclopedia, IEnumerable<DI.IRule<DM.Graphic>> rulesGraphic, IEnumerable<DI.IRule<DM.AudioRecording>> rulesAudioRecording, IEnumerable<DI.IRule<DM.VideoRecording>> rulesVideoRecording, IEnumerable<DI.IRule<DM.Broadcast>> rulesBroadcast, IEnumerable<DI.IRule<DM.PersonalCommunication>> rulesPersonalCommunication, IEnumerable<DI.IRule<DM.Interview>> rulesInterview, IEnumerable<DI.IRule<DM.Presentation>> rulesPresentation, IEnumerable<DI.IRule<DM.Map>> rulesMap, IEnumerable<DI.IRule<DM.Bill>> rulesBill, IEnumerable<DI.IRule<DM.Legislation>> rulesLegislation, IEnumerable<DI.IRule<DM.LegalCase>> rulesLegalCase, IEnumerable<DI.IRule<DM.Report>> rulesReport, IEnumerable<DI.IRule<DM.ConferencePaper>> rulesConferencePaper)
        {
            RuleManagerBook = new DG.RuleManager<DM.Book>();
            if (rulesBook != null)
            {
                rulesBook.Where(x => x != null)
                         .ToList()
                         .ForEach(x => RuleManagerBook.AddRule(x));
            }

            RuleManagerChapter = new DG.RuleManager<DM.Chapter>();
            if (rulesChapter != null)
            {
                rulesChapter.Where(x => x != null)
                            .ToList()
                            .ForEach(x => RuleManagerChapter.AddRule(x));
            }

            RuleManagerJournal = new DG.RuleManager<DM.Journal>();
            if (rulesJournal != null)
            {
                rulesJournal.Where(x => x != null)
                            .ToList()
                            .ForEach(x => RuleManagerJournal.AddRule(x));
            }

            RuleManagerMagazine = new DG.RuleManager<DM.Magazine>();
            if (rulesMagazine != null)
            {
                rulesMagazine.Where(x => x != null)
                             .ToList()
                             .ForEach(x => RuleManagerMagazine.AddRule(x));
            }

            RuleManagerNewspaper = new DG.RuleManager<DM.Newspaper>();
            if (rulesNewspaper != null)
            {
                rulesNewspaper.Where(x => x != null)
                              .ToList()
                              .ForEach(x => RuleManagerNewspaper.AddRule(x));
            }

            RuleManagerWebpage = new DG.RuleManager<DM.Webpage>();
            if (rulesWebpage != null)
            {
                rulesWebpage.Where(x => x != null)
                            .ToList()
                            .ForEach(x => RuleManagerWebpage.AddRule(x));
            }

            RuleManagerEncyclopedia = new DG.RuleManager<DM.Encyclopedia>();
            if (rulesEncyclopedia != null)
            {
                rulesEncyclopedia.Where(x => x != null)
                                 .ToList()
                                 .ForEach(x => RuleManagerEncyclopedia.AddRule(x));
            }

            RuleManagerGraphic = new DG.RuleManager<DM.Graphic>();
            if (rulesGraphic != null)
            {
                rulesGraphic.Where(x => x != null)
                            .ToList()
                            .ForEach(x => RuleManagerGraphic.AddRule(x));
            }

            RuleManagerAudioRecording = new DG.RuleManager<DM.AudioRecording>();
            if (rulesAudioRecording != null)
            {
                rulesAudioRecording.Where(x => x != null)
                                   .ToList()
                                   .ForEach(x => RuleManagerAudioRecording.AddRule(x));
            }

            RuleManagerVideoRecording = new DG.RuleManager<DM.VideoRecording>();
            if (rulesVideoRecording != null)
            {
                rulesVideoRecording.Where(x => x != null)
                                   .ToList()
                                   .ForEach(x => RuleManagerVideoRecording.AddRule(x));
            }

            RuleManagerBroadcast = new DG.RuleManager<DM.Broadcast>();
            if (rulesBroadcast != null)
            {
                rulesBroadcast.Where(x => x != null)
                              .ToList()
                              .ForEach(x => RuleManagerBroadcast.AddRule(x));
            }

            RuleManagerPersonalCommunication = new DG.RuleManager<DM.PersonalCommunication>();
            if (rulesPersonalCommunication != null)
            {
                rulesPersonalCommunication.Where(x => x != null)
                                          .ToList()
                                          .ForEach(x => RuleManagerPersonalCommunication.AddRule(x));
            }

            RuleManagerInterview = new DG.RuleManager<DM.Interview>();
            if (rulesInterview != null)
            {
                rulesInterview.Where(x => x != null)
                              .ToList()
                              .ForEach(x => RuleManagerInterview.AddRule(x));
            }

            RuleManagerPresentation = new DG.RuleManager<DM.Presentation>();
            if (rulesPresentation != null)
            {
                rulesPresentation.Where(x => x != null)
                                 .ToList()
                                 .ForEach(x => RuleManagerPresentation.AddRule(x));
            }

            RuleManagerMap = new DG.RuleManager<DM.Map>();
            if (rulesMap != null)
            {
                rulesMap.Where(x => x != null)
                        .ToList()
                        .ForEach(x => RuleManagerMap.AddRule(x));
            }

            RuleManagerBill = new DG.RuleManager<DM.Bill>();
            if (rulesBill != null)
            {
                rulesBill.Where(x => x != null)
                         .ToList()
                         .ForEach(x => RuleManagerBill.AddRule(x));
            }

            RuleManagerLegislation = new DG.RuleManager<DM.Legislation>();
            if (rulesLegislation != null)
            {
                rulesLegislation.Where(x => x != null)
                                .ToList()
                                .ForEach(x => RuleManagerLegislation.AddRule(x));
            }

            RuleManagerLegalCase = new DG.RuleManager<DM.LegalCase>();
            if (rulesLegalCase != null)
            {
                rulesLegalCase.Where(x => x != null)
                              .ToList()
                              .ForEach(x => RuleManagerLegalCase.AddRule(x));
            }

            RuleManagerReport = new DG.RuleManager<DM.Report>();
            if (rulesReport != null)
            {
                rulesReport.Where(x => x != null)
                           .ToList()
                           .ForEach(x => RuleManagerReport.AddRule(x));
            }

            RuleManagerConferencePaper = new DG.RuleManager<DM.ConferencePaper>();
            if (rulesConferencePaper != null)
            {
                rulesConferencePaper.Where(x => x != null)
                                    .ToList()
                                    .ForEach(x => RuleManagerConferencePaper.AddRule(x));
            }
        }

        #endregion

        #region Properties

        protected DG.RuleManager<DM.Book> RuleManagerBook { get; private set; }

        protected DG.RuleManager<DM.Chapter> RuleManagerChapter { get; private set; }

        protected DG.RuleManager<DM.Journal> RuleManagerJournal { get; private set; }

        protected DG.RuleManager<DM.Magazine> RuleManagerMagazine { get; private set; }

        protected DG.RuleManager<DM.Newspaper> RuleManagerNewspaper { get; private set; }

        protected DG.RuleManager<DM.Webpage> RuleManagerWebpage { get; private set; }

        protected DG.RuleManager<DM.Encyclopedia> RuleManagerEncyclopedia { get; private set; }

        protected DG.RuleManager<DM.Graphic> RuleManagerGraphic { get; private set; }

        protected DG.RuleManager<DM.AudioRecording> RuleManagerAudioRecording { get; private set; }

        protected DG.RuleManager<DM.VideoRecording> RuleManagerVideoRecording { get; private set; }

        protected DG.RuleManager<DM.Broadcast> RuleManagerBroadcast { get; private set; }

        protected DG.RuleManager<DM.PersonalCommunication> RuleManagerPersonalCommunication { get; private set; }

        protected DG.RuleManager<DM.Interview> RuleManagerInterview { get; private set; }

        protected DG.RuleManager<DM.Presentation> RuleManagerPresentation { get; private set; }

        protected DG.RuleManager<DM.Map> RuleManagerMap { get; private set; }

        protected DG.RuleManager<DM.Bill> RuleManagerBill { get; private set; }

        protected DG.RuleManager<DM.Legislation> RuleManagerLegislation { get; private set; }

        protected DG.RuleManager<DM.LegalCase> RuleManagerLegalCase { get; private set; }

        protected DG.RuleManager<DM.Report> RuleManagerReport { get; private set; }

        protected DG.RuleManager<DM.ConferencePaper> RuleManagerConferencePaper { get; private set; }

        #endregion

    }

}