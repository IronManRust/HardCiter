using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using DE = HardCiter.Processor.CiteProc.Enums;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class ContentItem
    {

        #region Constructors

        public ContentItem()
        {

            // Global ID

            ID = string.Empty;
            ItemTypeValue = DE.ItemType.Unknown;

            // Titles

            TitleFull = string.Empty;
            TitleShort = string.Empty;

            // Creators

            Authors = new List<Creator>();
            Editors = new List<Creator>();
            EditorialDirectors = new List<Creator>();
            Composers = new List<Creator>();
            Directors = new List<Creator>();
            Illustrators = new List<Creator>();
            Interviewers = new List<Creator>();
            Recipients = new List<Creator>();
            Translators = new List<Creator>();

            // Publisher

            PublisherName = string.Empty;
            PublisherLocation = string.Empty;

            // Original Information

            OriginalTitle = string.Empty;
            OriginalAuthors = new List<Creator>();
            OriginalDate = new DateInformation();
            OriginalPublisherName = string.Empty;
            OriginalPublisherLocation = string.Empty;

            // Container Information

            ContainerTitleFull = string.Empty;
            ContainerTitleShort = string.Empty;
            ContainerAuthors = new List<Creator>();
            ContainerDate = new DateInformation();

            // Collection Information

            CollectionTitle = string.Empty;
            CollectionEditors = new List<Creator>();
            CollectionNumber = null;

            // Reviewed Information

            ReviewedTitle = string.Empty;
            ReviewedAuthors = new List<Creator>();

            // Archive Information

            ArchiveName = string.Empty;
            ArchiveLocation = string.Empty;
            ArchivePlace = string.Empty;

            // Paging Information

            PageNumber = string.Empty;
            PageFirst = string.Empty;
            PageCount = null;

            // Citation Information

            CitationLabel = string.Empty;
            CitationNumber = string.Empty;

            // Event Information

            EventName = string.Empty;
            EventDate = new DateInformation();
            EventPlace = string.Empty;

            // Other IDs

            ISBN = string.Empty;
            ISSN = string.Empty;
            DOI = string.Empty;
            PMCID = string.Empty;
            PMID = string.Empty;

            // Other Metadata

            Abstract = string.Empty;
            AccessedDate = new DateInformation();
            Annote = string.Empty;
            Authority = string.Empty;
            CallNumber = string.Empty;
            ChapterNumber = null;
            Dimensions = string.Empty;
            Edition = string.Empty;
            FirstReferenceNoteNumber = string.Empty;
            Genre = string.Empty;
            Issue = string.Empty;
            IssuedDate = new DateInformation();
            Jurisdiction = string.Empty;
            Keyword = string.Empty;
            Language = string.Empty;
            Locator = string.Empty;
            Medium = string.Empty;
            Note = string.Empty;
            Number = null;
            References = string.Empty;
            Scale = string.Empty;
            Section = string.Empty;
            Source = string.Empty;
            Status = string.Empty;
            Submitted = new DateInformation();
            URL = string.Empty;
            Version = string.Empty;
            VolumeNumber = string.Empty;
            VolumeCount = null;
            YearSuffix = string.Empty;

        }

        #endregion

        #region Properties

        // Global ID

        [JsonProperty("id")]
        public string ID { get; set; }

        internal DE.ItemType ItemTypeValue { get; set; }

        [JsonProperty("type")]
        public string ItemType
        {
            get
            {
                switch (ItemTypeValue)
                {
                    case DE.ItemType.Unknown:
                        return string.Empty;
                    case DE.ItemType.Book:
                        return "book";
                    case DE.ItemType.Chapter:
                        return "chapter";
                    case DE.ItemType.Journal:
                        return "article-journal";
                    case DE.ItemType.Magazine:
                        return "article-magazine";
                    case DE.ItemType.Newspaper:
                        return "article-newspaper";
                    case DE.ItemType.Webpage:
                        return "webpage";
                    case DE.ItemType.Encyclopedia:
                        return "entry-encyclopedia";
                    case DE.ItemType.Graphic:
                        return "graphic";
                    case DE.ItemType.AudioRecording:
                        return "song";
                    case DE.ItemType.VideoRecording:
                        return "motion_picture";
                    case DE.ItemType.Broadcast:
                        return "broadcast";
                    case DE.ItemType.PersonalCommunication:
                        return "personal_communication";
                    case DE.ItemType.Interview:
                        return "interview";
                    case DE.ItemType.Presentation:
                        return "speech";
                    case DE.ItemType.Map:
                        return "map";
                    case DE.ItemType.Bill:
                        return "bill";
                    case DE.ItemType.Legislation:
                        return "legislation";
                    case DE.ItemType.LegalCase:
                        return "legal_case";
                    case DE.ItemType.Report:
                        return "report";
                    case DE.ItemType.ConferencePaper:
                        return "paper-conference";
                    default:
                        return string.Empty;
                }
            }
        }

        // Titles

        [JsonProperty("title")]
        public string TitleFull { get; set; }

        [JsonProperty("title-short")]
        public string TitleShort { get; set; }

        // Creators

        [JsonProperty("author")]
        public List<Creator> Authors { get; set; }

        [JsonProperty("editor")]
        public List<Creator> Editors { get; set; }

        [JsonProperty("editorial-director")]
        public List<Creator> EditorialDirectors { get; set; }

        [JsonProperty("composer")]
        public List<Creator> Composers { get; set; }

        [JsonProperty("director")]
        public List<Creator> Directors { get; set; }

        [JsonProperty("illustrator")]
        public List<Creator> Illustrators { get; set; }

        [JsonProperty("interviewer")]
        public List<Creator> Interviewers { get; set; }

        [JsonProperty("recipient")]
        public List<Creator> Recipients { get; set; }

        [JsonProperty("translator")]
        public List<Creator> Translators { get; set; }

        // Publisher

        [JsonProperty("publisher")]
        public string PublisherName { get; set; }

        [JsonProperty("publisher-place")]
        public string PublisherLocation { get; set; }

        // Original Information

        [JsonProperty("original-title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("original-author")]
        public List<Creator> OriginalAuthors { get; set; }

        [JsonProperty("original-date")]
        public DateInformation OriginalDate { get; set; }

        [JsonProperty("original-publisher")]
        public string OriginalPublisherName { get; set; }

        [JsonProperty("original-publisher-place")]
        public string OriginalPublisherLocation { get; set; }

        // Container Information

        [JsonProperty("container-title")]
        public string ContainerTitleFull { get; set; }

        [JsonProperty("container-title-short")]
        public string ContainerTitleShort { get; set; }

        [JsonProperty("container-author")]
        public List<Creator> ContainerAuthors { get; set; }

        [JsonProperty("container")]
        public DateInformation ContainerDate { get; set; }

        // Collection Information

        [JsonProperty("collection-title")]
        public string CollectionTitle { get; set; }

        [JsonProperty("collection-editor")]
        public List<Creator> CollectionEditors { get; set; }

        [JsonProperty("collection-number")]
        public int? CollectionNumber { get; set; }

        // Reviewed Information

        [JsonProperty("reviewed-title")]
        public string ReviewedTitle { get; set; }

        [JsonProperty("reviewed-author")]
        public List<Creator> ReviewedAuthors { get; set; }

        // Archive Information

        [JsonProperty("archive")]
        public string ArchiveName { get; set; }

        [JsonProperty("archive_location")]
        public string ArchiveLocation { get; set; }

        [JsonProperty("archive-place")]
        public string ArchivePlace { get; set; }

        // Paging Information

        [JsonProperty("page")]
        public string PageNumber { get; set; }

        [JsonProperty("page-first")]
        public string PageFirst { get; set; }

        [JsonProperty("number-of-pages")]
        public int? PageCount { get; set; }

        // Citation Information

        [JsonProperty("citation-label")]
        public string CitationLabel { get; set; }

        [JsonProperty("citation-number")]
        public string CitationNumber { get; set; }

        // Event Information

        [JsonProperty("event")]
        public string EventName { get; set; }

        [JsonProperty("event-date")]
        public DateInformation EventDate { get; set; }

        [JsonProperty("event-place")]
        public string EventPlace { get; set; }

        // Other IDs

        [JsonProperty("ISBN")]
        public string ISBN { get; set; }

        [JsonProperty("ISSN")]
        public string ISSN { get; set; }

        [JsonProperty("DOI")]
        public string DOI { get; set; }

        [JsonProperty("PMCID")]
        public string PMCID { get; set; }

        [JsonProperty("PMID")]
        public string PMID { get; set; }

        // Other Metadata

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("accessed")]
        public DateInformation AccessedDate { get; set; }

        [JsonProperty("annote")]
        public string Annote { get; set; }

        [JsonProperty("authority")]
        public string Authority { get; set; }

        [JsonProperty("call-number")]
        public string CallNumber { get; set; }

        [JsonProperty("chapter-number")]
        public int? ChapterNumber { get; set; }

        [JsonProperty("dimensions")]
        public string Dimensions { get; set; }

        [JsonProperty("edition")]
        public string Edition { get; set; }

        [JsonProperty("first-reference-note-number")]
        public string FirstReferenceNoteNumber { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("issue")]
        public string Issue { get; set; }

        [JsonProperty("issued")]
        public DateInformation IssuedDate { get; set; }

        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("locator")]
        public string Locator { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("references")]
        public string References { get; set; }

        [JsonProperty("scale")]
        public string Scale { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("submitted")]
        public DateInformation Submitted { get; set; }

        [JsonProperty("URL")]
        public string URL { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("volume")]
        public string VolumeNumber { get; set; }

        [JsonProperty("number-of-volumes")]
        public int? VolumeCount { get; set; }

        [JsonProperty("year-suffix")]
        public string YearSuffix { get; set; }

        #endregion

    }

}