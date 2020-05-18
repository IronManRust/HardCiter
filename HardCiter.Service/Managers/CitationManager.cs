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

    internal class CitationManager : RootManager
    {

        #region Variables

        private CitationProcessor _citationProcessor;

        #endregion

        #region Constructors

        internal CitationManager(INodeServices nodeServices)
        {
            _citationProcessor = GetCitationProcessor(nodeServices);
        }

        #endregion

        #region Methods

        internal SM.Citation CreateCitationBook(SE.Style style, SE.Format format, SM.Book book)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationBook(ContentItemFactory.Build(style),
                                                                                  ContentItemFactory.Build(format),
                                                                                  ContentItemFactory.Build(book)));
        }

        internal SM.Citation CreateCitationChapter(SE.Style style, SE.Format format, SM.Chapter chapter)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationChapter(ContentItemFactory.Build(style),
                                                                                     ContentItemFactory.Build(format),
                                                                                     ContentItemFactory.Build(chapter)));
        }

        internal SM.Citation CreateCitationJournal(SE.Style style, SE.Format format, SM.Journal journal)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationJournal(ContentItemFactory.Build(style),
                                                                                     ContentItemFactory.Build(format),
                                                                                     ContentItemFactory.Build(journal)));
        }

        internal SM.Citation CreateCitationMagazine(SE.Style style, SE.Format format, SM.Magazine magazine)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationMagazine(ContentItemFactory.Build(style),
                                                                                      ContentItemFactory.Build(format),
                                                                                      ContentItemFactory.Build(magazine)));
        }

        internal SM.Citation CreateCitationNewspaper(SE.Style style, SE.Format format, SM.Newspaper newspaper)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationNewspaper(ContentItemFactory.Build(style),
                                                                                       ContentItemFactory.Build(format),
                                                                                       ContentItemFactory.Build(newspaper)));
        }

        internal SM.Citation CreateCitationWebpage(SE.Style style, SE.Format format, SM.Webpage webpage)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationWebpage(ContentItemFactory.Build(style),
                                                                                     ContentItemFactory.Build(format),
                                                                                     ContentItemFactory.Build(webpage)));
        }

        internal SM.Citation CreateCitationEncyclopedia(SE.Style style, SE.Format format, SM.Encyclopedia encyclopedia)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationEncyclopedia(ContentItemFactory.Build(style),
                                                                                          ContentItemFactory.Build(format),
                                                                                          ContentItemFactory.Build(encyclopedia)));
        }

        internal SM.Citation CreateCitationGraphic(SE.Style style, SE.Format format, SM.Graphic graphic)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationGraphic(ContentItemFactory.Build(style),
                                                                                     ContentItemFactory.Build(format),
                                                                                     ContentItemFactory.Build(graphic)));
        }

        internal SM.Citation CreateCitationAudioRecording(SE.Style style, SE.Format format, SM.AudioRecording audioRecording)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationAudioRecording(ContentItemFactory.Build(style),
                                                                                            ContentItemFactory.Build(format),
                                                                                            ContentItemFactory.Build(audioRecording)));
        }

        internal SM.Citation CreateCitationVideoRecording(SE.Style style, SE.Format format, SM.VideoRecording videoRecording)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationVideoRecording(ContentItemFactory.Build(style),
                                                                                            ContentItemFactory.Build(format),
                                                                                            ContentItemFactory.Build(videoRecording)));
        }

        internal SM.Citation CreateCitationBroadcast(SE.Style style, SE.Format format, SM.Broadcast broadcast)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationBroadcast(ContentItemFactory.Build(style),
                                                                                       ContentItemFactory.Build(format),
                                                                                       ContentItemFactory.Build(broadcast)));
        }

        internal SM.Citation CreateCitationPersonalCommunication(SE.Style style, SE.Format format, SM.PersonalCommunication personalCommunication)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationPersonalCommunication(ContentItemFactory.Build(style),
                                                                                                   ContentItemFactory.Build(format),
                                                                                                   ContentItemFactory.Build(personalCommunication)));
        }

        internal SM.Citation CreateCitationInterview(SE.Style style, SE.Format format, SM.Interview interview)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationInterview(ContentItemFactory.Build(style),
                                                                                       ContentItemFactory.Build(format),
                                                                                       ContentItemFactory.Build(interview)));
        }

        internal SM.Citation CreateCitationPresentation(SE.Style style, SE.Format format, SM.Presentation presentation)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationPresentation(ContentItemFactory.Build(style),
                                                                                          ContentItemFactory.Build(format),
                                                                                          ContentItemFactory.Build(presentation)));
        }

        internal SM.Citation CreateCitationMap(SE.Style style, SE.Format format, SM.Map map)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationMap(ContentItemFactory.Build(style),
                                                                                 ContentItemFactory.Build(format),
                                                                                 ContentItemFactory.Build(map)));
        }

        internal SM.Citation CreateCitationBill(SE.Style style, SE.Format format, SM.Bill bill)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationBill(ContentItemFactory.Build(style),
                                                                                  ContentItemFactory.Build(format),
                                                                                  ContentItemFactory.Build(bill)));
        }

        internal SM.Citation CreateCitationLegislation(SE.Style style, SE.Format format, SM.Legislation legislation)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationLegislation(ContentItemFactory.Build(style),
                                                                                         ContentItemFactory.Build(format),
                                                                                         ContentItemFactory.Build(legislation)));
        }

        internal SM.Citation CreateCitationLegalCase(SE.Style style, SE.Format format, SM.LegalCase legalCase)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationLegalCase(ContentItemFactory.Build(style),
                                                                                       ContentItemFactory.Build(format),
                                                                                       ContentItemFactory.Build(legalCase)));
        }

        internal SM.Citation CreateCitationReport(SE.Style style, SE.Format format, SM.Report report)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationReport(ContentItemFactory.Build(style),
                                                                                    ContentItemFactory.Build(format),
                                                                                    ContentItemFactory.Build(report)));
        }

        internal SM.Citation CreateCitationConferencePaper(SE.Style style, SE.Format format, SM.ConferencePaper conferencePaper)
        {
            return ContentItemFactory.Build(_citationProcessor.CreateCitationConferencePaper(ContentItemFactory.Build(style),
                                                                                             ContentItemFactory.Build(format),
                                                                                             ContentItemFactory.Build(conferencePaper)));
        }

        #endregion

    }

}