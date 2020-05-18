using System;

namespace HardCiter.Service.Configuration
{

    /// <summary>
    /// Describes API routing paths.
    /// </summary>
    public static class Routes
    {

        #region Constants

        /// <summary>
        /// Generates a bibliography.
        /// </summary>
        public const string Bibliography = "/api/1.0/bibliography";

        /// <summary>
        /// Generates an in-line book citation.
        /// </summary>
        public const string CitationBook = "/api/1.0/citation/book";

        /// <summary>
        /// Generates an in-line chapter citation.
        /// </summary>
        public const string CitationChapter = "/api/1.0/citation/chapter";

        /// <summary>
        /// Generates an in-line journal citation.
        /// </summary>
        public const string CitationJournal = "/api/1.0/citation/journal";

        /// <summary>
        /// Generates an in-line magazine citation.
        /// </summary>
        public const string CitationMagazine = "/api/1.0/citation/magazine";

        /// <summary>
        /// Generates an in-line newspaper citation.
        /// </summary>
        public const string CitationNewspaper = "/api/1.0/citation/newspaper";

        /// <summary>
        /// Generates an in-line webpage citation.
        /// </summary>
        public const string CitationWebpage = "/api/1.0/citation/webpage";

        /// <summary>
        /// Generates an in-line encyclopedia citation.
        /// </summary>
        public const string CitationEncyclopedia = "/api/1.0/citation/encyclopedia";

        /// <summary>
        /// Generates an in-line graphic citation.
        /// </summary>
        public const string CitationGraphic = "/api/1.0/citation/graphic";

        /// <summary>
        /// Generates an in-line audio recording citation.
        /// </summary>
        public const string CitationAudioRecording = "/api/1.0/citation/audio-recording";

        /// <summary>
        /// Generates an in-line video recording citation.
        /// </summary>
        public const string CitationVideoRecording = "/api/1.0/citation/video-recording";

        /// <summary>
        /// Generates an in-line broadcast citation.
        /// </summary>
        public const string CitationBroadcast = "/api/1.0/citation/broadcast";

        /// <summary>
        /// Generates an in-line personal communication citation.
        /// </summary>
        public const string CitationPersonalCommunication = "/api/1.0/citation/personal-communication";

        /// <summary>
        /// Generates an in-line interview citation.
        /// </summary>
        public const string CitationInterview = "/api/1.0/citation/interview";

        /// <summary>
        /// Generates an in-line presentation citation.
        /// </summary>
        public const string CitationPresentation = "/api/1.0/citation/presentation";

        /// <summary>
        /// Generates an in-line map citation.
        /// </summary>
        public const string CitationMap = "/api/1.0/citation/map";

        /// <summary>
        /// Generates an in-line bill citation.
        /// </summary>
        public const string CitationBill = "/api/1.0/citation/bill";

        /// <summary>
        /// Generates an in-line legislation citation.
        /// </summary>
        public const string CitationLegislation = "/api/1.0/citation/legislation";

        /// <summary>
        /// Generates an in-line legal case citation.
        /// </summary>
        public const string CitationLegalCase = "/api/1.0/citation/legal-case";

        /// <summary>
        /// Generates an in-line report citation.
        /// </summary>
        public const string CitationReport = "/api/1.0/citation/report";

        /// <summary>
        /// Generates an in-line conference paper citation.
        /// </summary>
        public const string CitationConferencePaper = "/api/1.0/citation/conference-paper";

        /// <summary>
        /// Gets the status of the service.
        /// </summary>
        public const string Status = "/api/1.0/status";

        #endregion

    }

}