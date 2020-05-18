using System;
using System.Collections.Generic;
using DE = HardCiter.Domain.Enums;
using DM = HardCiter.Domain.Models;

namespace HardCiter.Domain.Interfaces
{

    public interface ICitationProcessor
    {

        #region Methods

        List<KeyValuePair<string, string>> GetMetaData();

        DM.Citation CreateCitationBook(DE.Style style, DE.Format format, DM.Book book);

        DM.Citation CreateCitationChapter(DE.Style style, DE.Format format, DM.Chapter chapter);

        DM.Citation CreateCitationJournal(DE.Style style, DE.Format format, DM.Journal journal);

        DM.Citation CreateCitationMagazine(DE.Style style, DE.Format format, DM.Magazine magazine);

        DM.Citation CreateCitationNewspaper(DE.Style style, DE.Format format, DM.Newspaper newspaper);

        DM.Citation CreateCitationWebpage(DE.Style style, DE.Format format, DM.Webpage webpage);

        DM.Citation CreateCitationEncyclopedia(DE.Style style, DE.Format format, DM.Encyclopedia encyclopedia);

        DM.Citation CreateCitationGraphic(DE.Style style, DE.Format format, DM.Graphic graphic);

        DM.Citation CreateCitationAudioRecording(DE.Style style, DE.Format format, DM.AudioRecording audioRecording);

        DM.Citation CreateCitationVideoRecording(DE.Style style, DE.Format format, DM.VideoRecording videoRecording);

        DM.Citation CreateCitationBroadcast(DE.Style style, DE.Format format, DM.Broadcast broadcast);

        DM.Citation CreateCitationPersonalCommunication(DE.Style style, DE.Format format, DM.PersonalCommunication personalCommunication);

        DM.Citation CreateCitationInterview(DE.Style style, DE.Format format, DM.Interview interview);

        DM.Citation CreateCitationPresentation(DE.Style style, DE.Format format, DM.Presentation presentation);

        DM.Citation CreateCitationMap(DE.Style style, DE.Format format, DM.Map map);

        DM.Citation CreateCitationBill(DE.Style style, DE.Format format, DM.Bill bill);

        DM.Citation CreateCitationLegislation(DE.Style style, DE.Format format, DM.Legislation legislation);

        DM.Citation CreateCitationLegalCase(DE.Style style, DE.Format format, DM.LegalCase legalCase);

        DM.Citation CreateCitationReport(DE.Style style, DE.Format format, DM.Report report);

        DM.Citation CreateCitationConferencePaper(DE.Style style, DE.Format format, DM.ConferencePaper conferencePaper);

        #endregion

    }

}