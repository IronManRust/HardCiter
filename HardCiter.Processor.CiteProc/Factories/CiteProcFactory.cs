using System;
using System.Collections.Generic;
using System.Linq;
using DE = HardCiter.Domain.Enums;
using DM = HardCiter.Domain.Models;
using PE = HardCiter.Processor.CiteProc.Enums;
using PM = HardCiter.Processor.CiteProc.Models;

namespace HardCiter.Processor.CiteProc.Factories
{

    internal static class CiteProcFactory
    {

        #region Methods - Domain To Library

        internal static string Build(DE.Format format)
        {
            switch (format)
            {
                case DE.Format.Unknown:
                    throw new ArgumentException("Invalid Format");
                case DE.Format.Text:
                    return "text";
                case DE.Format.HTML:
                    return "html";
                default:
                    throw new NotImplementedException();
            }
        }

        internal static PM.ContentItem Build(string id, DM.ContentItem contentItem)
        {
            if (contentItem != null)
            {
                switch (contentItem.ItemType)
                {
                    case DE.ItemType.Unknown:
                        throw new ArgumentException("Invalid ItemType");
                    case DE.ItemType.Book:
                        return Build(id, contentItem as DM.Book);
                    case DE.ItemType.Chapter:
                        return Build(id, contentItem as DM.Chapter);
                    case DE.ItemType.Journal:
                        return Build(id, contentItem as DM.Journal);
                    case DE.ItemType.Magazine:
                        return Build(id, contentItem as DM.Magazine);
                    case DE.ItemType.Newspaper:
                        return Build(id, contentItem as DM.Newspaper);
                    case DE.ItemType.Webpage:
                        return Build(id, contentItem as DM.Webpage);
                    case DE.ItemType.Encyclopedia:
                        return Build(id, contentItem as DM.Encyclopedia);
                    case DE.ItemType.Graphic:
                        return Build(id, contentItem as DM.Graphic);
                    case DE.ItemType.AudioRecording:
                        return Build(id, contentItem as DM.AudioRecording);
                    case DE.ItemType.VideoRecording:
                        return Build(id, contentItem as DM.VideoRecording);
                    case DE.ItemType.Broadcast:
                        return Build(id, contentItem as DM.Broadcast);
                    case DE.ItemType.PersonalCommunication:
                        return Build(id, contentItem as DM.PersonalCommunication);
                    case DE.ItemType.Interview:
                        return Build(id, contentItem as DM.Interview);
                    case DE.ItemType.Presentation:
                        return Build(id, contentItem as DM.Presentation);
                    case DE.ItemType.Map:
                        return Build(id, contentItem as DM.Map);
                    case DE.ItemType.Bill:
                        return Build(id, contentItem as DM.Bill);
                    case DE.ItemType.Legislation:
                        return Build(id, contentItem as DM.Legislation);
                    case DE.ItemType.LegalCase:
                        return Build(id, contentItem as DM.LegalCase);
                    case DE.ItemType.Report:
                        return Build(id, contentItem as DM.Report);
                    case DE.ItemType.ConferencePaper:
                        return Build(id, contentItem as DM.ConferencePaper);
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Book book)
        {
            if (book != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Book,
                    TitleFull = book.TitleFull,
                    TitleShort = book.TitleShort,
                    Authors = book.Creators != null ? book.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Editors = book.Creators != null ? book.Creators.Where(x => x.Type == DE.CreatorType.Editor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = book.Creators != null ? book.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherName = book.PublisherName,
                    PublisherLocation = book.PublisherLocation,
                    CollectionTitle = book.CollectionTitle,
                    CollectionEditors = book.Creators != null ? book.Creators.Where(x => x.Type == DE.CreatorType.CollectionEditor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    CollectionNumber = book.CollectionNumber,
                    ArchiveName = book.ArchiveName,
                    ArchiveLocation = book.ArchiveLocation,
                    PageCount = book.PageCount,
                    EventPlace = book.EventPlace,
                    ISBN = book.ISBN,
                    Abstract = book.Abstract,
                    AccessedDate = new PM.DateInformation(book.AccessedDate),
                    CallNumber = book.CallNumber,
                    Edition = book.Edition,
                    IssuedDate = new PM.DateInformation(book.IssuedDate),
                    Language = book.Language,
                    Note = book.Note,
                    Source = book.Source,
                    URL = book.URL,
                    VolumeNumber = book.VolumeNumber,
                    VolumeCount = book.VolumeCount
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Chapter chapter)
        {
            if (chapter != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Chapter,
                    TitleFull = chapter.TitleFull,
                    TitleShort = chapter.TitleShort,
                    Authors = chapter.Creators != null ? chapter.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Editors = chapter.Creators != null ? chapter.Creators.Where(x => x.Type == DE.CreatorType.Editor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = chapter.Creators != null ? chapter.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherName = chapter.PublisherName,
                    PublisherLocation = chapter.PublisherLocation,
                    ContainerTitleFull = chapter.ContainerTitle,
                    ContainerAuthors = chapter.Creators != null ? chapter.Creators.Where(x => x.Type == DE.CreatorType.ContainerAuthor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    CollectionTitle = chapter.CollectionTitle,
                    CollectionEditors = chapter.Creators != null ? chapter.Creators.Where(x => x.Type == DE.CreatorType.CollectionEditor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    CollectionNumber = chapter.CollectionNumber,
                    ArchiveName = chapter.ArchiveName,
                    ArchiveLocation = chapter.ArchiveLocation,
                    PageNumber = chapter.PageNumber,
                    EventPlace = chapter.EventPlace,
                    ISBN = chapter.ISBN,
                    Abstract = chapter.Abstract,
                    AccessedDate = new PM.DateInformation(chapter.AccessedDate),
                    CallNumber = chapter.CallNumber,
                    Edition = chapter.Edition,
                    IssuedDate = new PM.DateInformation(chapter.IssuedDate),
                    Language = chapter.Language,
                    Note = chapter.Note,
                    Source = chapter.Source,
                    URL = chapter.URL,
                    VolumeNumber = chapter.VolumeNumber,
                    VolumeCount = chapter.VolumeCount
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Journal journal)
        {
            if (journal != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Journal,
                    TitleFull = journal.TitleFull,
                    TitleShort = journal.TitleShort,
                    Authors = journal.Creators != null ? journal.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Editors = journal.Creators != null ? journal.Creators.Where(x => x.Type == DE.CreatorType.Editor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ReviewedAuthors = journal.Creators != null ? journal.Creators.Where(x => x.Type == DE.CreatorType.ReviewedAuthor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = journal.Creators != null ? journal.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ContainerTitleFull = journal.ContainerTitleFull,
                    ContainerTitleShort = journal.ContainerTitleShort,
                    CollectionTitle = journal.CollectionTitle,
                    ArchiveName = journal.ArchiveName,
                    ArchiveLocation = journal.ArchiveLocation,
                    PageNumber = journal.PageNumber,
                    ISSN = journal.ISSN,
                    DOI = journal.DOI,
                    Abstract = journal.Abstract,
                    AccessedDate = new PM.DateInformation(journal.AccessedDate),
                    CallNumber = journal.CallNumber,
                    Issue = journal.Issue,
                    IssuedDate = new PM.DateInformation(journal.IssuedDate),
                    Language = journal.Language,
                    Note = journal.Note,
                    Source = journal.Source,
                    URL = journal.URL,
                    VolumeNumber = journal.Volume
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Magazine magazine)
        {
            if (magazine != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Magazine,
                    TitleFull = magazine.TitleFull,
                    TitleShort = magazine.TitleShort,
                    Authors = magazine.Creators != null ? magazine.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ReviewedAuthors = magazine.Creators != null ? magazine.Creators.Where(x => x.Type == DE.CreatorType.ReviewedAuthor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = magazine.Creators != null ? magazine.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ContainerTitleFull = magazine.ContainerTitleFull,
                    ArchiveName = magazine.ArchiveName,
                    ArchiveLocation = magazine.ArchiveLocation,
                    PageNumber = magazine.PageNumber,
                    ISSN = magazine.ISSN,
                    Abstract = magazine.Abstract,
                    AccessedDate = new PM.DateInformation(magazine.AccessedDate),
                    CallNumber = magazine.CallNumber,
                    Issue = magazine.Issue,
                    IssuedDate = new PM.DateInformation(magazine.IssuedDate),
                    Language = magazine.Language,
                    Note = magazine.Note,
                    Source = magazine.Source,
                    URL = magazine.URL,
                    VolumeNumber = magazine.Volume
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Newspaper newspaper)
        {
            if (newspaper != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Newspaper,
                    TitleFull = newspaper.TitleFull,
                    TitleShort = newspaper.TitleShort,
                    Authors = newspaper.Creators != null ? newspaper.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ReviewedAuthors = newspaper.Creators != null ? newspaper.Creators.Where(x => x.Type == DE.CreatorType.ReviewedAuthor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = newspaper.Creators != null ? newspaper.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherLocation = newspaper.PublisherLocation,
                    ContainerTitleFull = newspaper.ContainerTitleFull,
                    ArchiveName = newspaper.ArchiveName,
                    ArchiveLocation = newspaper.ArchiveLocation,
                    PageNumber = newspaper.PageNumber,
                    EventPlace = newspaper.EventPlace,
                    ISSN = newspaper.ISSN,
                    Abstract = newspaper.Abstract,
                    AccessedDate = new PM.DateInformation(newspaper.AccessedDate),
                    CallNumber = newspaper.CallNumber,
                    Edition = newspaper.Edition,
                    IssuedDate = new PM.DateInformation(newspaper.IssuedDate),
                    Language = newspaper.Language,
                    Note = newspaper.Note,
                    Section = newspaper.Section,
                    Source = newspaper.Source,
                    URL = newspaper.URL
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Webpage webpage)
        {
            if (webpage != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Webpage,
                    TitleFull = webpage.TitleFull,
                    TitleShort = webpage.TitleShort,
                    Authors = webpage.Creators != null ? webpage.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = webpage.Creators != null ? webpage.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ContainerTitleFull = webpage.ContainerTitle,
                    Abstract = webpage.Abstract,
                    AccessedDate = new PM.DateInformation(webpage.AccessedDate),
                    Genre = webpage.Genre,
                    IssuedDate = new PM.DateInformation(webpage.IssuedDate),
                    Language = webpage.Language,
                    Note = webpage.Note,
                    URL = webpage.URL
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Encyclopedia encyclopedia)
        {
            if (encyclopedia != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Encyclopedia,
                    TitleFull = encyclopedia.TitleFull,
                    TitleShort = encyclopedia.TitleShort,
                    Authors = encyclopedia.Creators != null ? encyclopedia.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Editors = encyclopedia.Creators != null ? encyclopedia.Creators.Where(x => x.Type == DE.CreatorType.Editor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = encyclopedia.Creators != null ? encyclopedia.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherName = encyclopedia.PublisherName,
                    PublisherLocation = encyclopedia.PublisherLocation,
                    ContainerTitleFull = encyclopedia.ContainerTitle,
                    CollectionTitle = encyclopedia.CollectionTitle,
                    CollectionEditors = encyclopedia.Creators != null ? encyclopedia.Creators.Where(x => x.Type == DE.CreatorType.CollectionEditor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    CollectionNumber = encyclopedia.CollectionNumber,
                    ArchiveName = encyclopedia.ArchiveName,
                    ArchiveLocation = encyclopedia.ArchiveLocation,
                    PageNumber = encyclopedia.PageNumber,
                    EventPlace = encyclopedia.EventPlace,
                    ISBN = encyclopedia.ISBN,
                    Abstract = encyclopedia.Abstract,
                    AccessedDate = new PM.DateInformation(encyclopedia.AccessedDate),
                    CallNumber = encyclopedia.CallNumber,
                    Edition = encyclopedia.Edition,
                    IssuedDate = new PM.DateInformation(encyclopedia.IssuedDate),
                    Language = encyclopedia.Language,
                    Note = encyclopedia.Note,
                    Source = encyclopedia.Source,
                    URL = encyclopedia.URL,
                    VolumeNumber = encyclopedia.VolumeNumber,
                    VolumeCount = encyclopedia.VolumeCount
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Graphic graphic)
        {
            if (graphic != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Graphic,
                    TitleFull = graphic.TitleFull,
                    TitleShort = graphic.TitleShort,
                    Authors = graphic.Creators != null ? graphic.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = graphic.Creators != null ? graphic.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ArchiveName = graphic.ArchiveName,
                    ArchiveLocation = graphic.ArchiveLocation,
                    Abstract = graphic.Abstract,
                    AccessedDate = new PM.DateInformation(graphic.AccessedDate),
                    CallNumber = graphic.CallNumber,
                    Dimensions = graphic.Dimensions,
                    IssuedDate = new PM.DateInformation(graphic.IssuedDate),
                    Language = graphic.Language,
                    Medium = graphic.Medium,
                    Note = graphic.Note,
                    Source = graphic.Source,
                    URL = graphic.URL
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.AudioRecording audioRecording)
        {
            if (audioRecording != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.AudioRecording,
                    TitleFull = audioRecording.TitleFull,
                    TitleShort = audioRecording.TitleShort,
                    Authors = audioRecording.Creators != null ? audioRecording.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Composers = audioRecording.Creators != null ? audioRecording.Creators.Where(x => x.Type == DE.CreatorType.Composer).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = audioRecording.Creators != null ? audioRecording.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherName = audioRecording.PublisherName,
                    PublisherLocation = audioRecording.PublisherLocation,
                    CollectionTitle = audioRecording.CollectionTitle,
                    ArchiveName = audioRecording.ArchiveName,
                    ArchiveLocation = audioRecording.ArchiveLocation,
                    EventPlace = audioRecording.EventPlace,
                    ISBN = audioRecording.ISBN,
                    Abstract = audioRecording.Abstract,
                    AccessedDate = new PM.DateInformation(audioRecording.AccessedDate),
                    CallNumber = audioRecording.CallNumber,
                    Dimensions = audioRecording.Dimensions,
                    IssuedDate = new PM.DateInformation(audioRecording.IssuedDate),
                    Language = audioRecording.Language,
                    Medium = audioRecording.Medium,
                    Note = audioRecording.Note,
                    Source = audioRecording.Source,
                    URL = audioRecording.URL,
                    VolumeNumber = audioRecording.VolumeNumber,
                    VolumeCount = audioRecording.VolumeCount
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.VideoRecording videoRecording)
        {
            if (videoRecording != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.VideoRecording,
                    TitleFull = videoRecording.TitleFull,
                    TitleShort = videoRecording.TitleShort,
                    Authors = videoRecording.Creators != null ? videoRecording.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = videoRecording.Creators != null ? videoRecording.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherName = videoRecording.PublisherName,
                    PublisherLocation = videoRecording.PublisherLocation,
                    CollectionTitle = videoRecording.CollectionTitle,
                    ArchiveName = videoRecording.ArchiveName,
                    ArchiveLocation = videoRecording.ArchiveLocation,
                    EventPlace = videoRecording.EventPlace,
                    ISBN = videoRecording.ISBN,
                    Abstract = videoRecording.Abstract,
                    AccessedDate = new PM.DateInformation(videoRecording.AccessedDate),
                    CallNumber = videoRecording.CallNumber,
                    Dimensions = videoRecording.Dimensions,
                    IssuedDate = new PM.DateInformation(videoRecording.IssuedDate),
                    Language = videoRecording.Language,
                    Medium = videoRecording.Medium,
                    Note = videoRecording.Note,
                    Source = videoRecording.Source,
                    URL = videoRecording.URL,
                    VolumeNumber = videoRecording.VolumeNumber,
                    VolumeCount = videoRecording.VolumeCount
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Broadcast broadcast)
        {
            if (broadcast != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Broadcast,
                    TitleFull = broadcast.TitleFull,
                    TitleShort = broadcast.TitleShort,
                    Authors = broadcast.Creators != null ? broadcast.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = broadcast.Creators != null ? broadcast.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherName = broadcast.PublisherName,
                    PublisherLocation = broadcast.PublisherLocation,
                    ContainerTitleFull = broadcast.ContainerTitle,
                    ArchiveName = broadcast.ArchiveName,
                    ArchiveLocation = broadcast.ArchiveLocation,
                    EventPlace = broadcast.EventPlace,
                    Abstract = broadcast.Abstract,
                    AccessedDate = new PM.DateInformation(broadcast.AccessedDate),
                    CallNumber = broadcast.CallNumber,
                    Dimensions = broadcast.Dimensions,
                    IssuedDate = new PM.DateInformation(broadcast.IssuedDate),
                    Language = broadcast.Language,
                    Medium = broadcast.Medium,
                    Note = broadcast.Note,
                    Number = broadcast.Number,
                    Source = broadcast.Source,
                    URL = broadcast.URL
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.PersonalCommunication personalCommunication)
        {
            if (personalCommunication != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.PersonalCommunication,
                    TitleFull = personalCommunication.TitleFull,
                    TitleShort = personalCommunication.TitleShort,
                    Authors = personalCommunication.Creators != null ? personalCommunication.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Recipients = personalCommunication.Creators != null ? personalCommunication.Creators.Where(x => x.Type == DE.CreatorType.Recipient).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = personalCommunication.Creators != null ? personalCommunication.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ArchiveName = personalCommunication.ArchiveName,
                    ArchiveLocation = personalCommunication.ArchiveLocation,
                    Abstract = personalCommunication.Abstract,
                    AccessedDate = new PM.DateInformation(personalCommunication.AccessedDate),
                    CallNumber = personalCommunication.CallNumber,
                    Genre = personalCommunication.Genre,
                    IssuedDate = new PM.DateInformation(personalCommunication.IssuedDate),
                    Language = personalCommunication.Language,
                    Note = personalCommunication.Note,
                    Source = personalCommunication.Source,
                    URL = personalCommunication.URL
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Interview interview)
        {
            if (interview != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Interview,
                    TitleFull = interview.TitleFull,
                    TitleShort = interview.TitleShort,
                    Authors = interview.Creators != null ? interview.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Interviewers = interview.Creators != null ? interview.Creators.Where(x => x.Type == DE.CreatorType.Interviewer).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = interview.Creators != null ? interview.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ArchiveName = interview.ArchiveName,
                    ArchiveLocation = interview.ArchiveLocation,
                    Abstract = interview.Abstract,
                    AccessedDate = new PM.DateInformation(interview.AccessedDate),
                    CallNumber = interview.CallNumber,
                    IssuedDate = new PM.DateInformation(interview.IssuedDate),
                    Language = interview.Language,
                    Medium = interview.Medium,
                    Note = interview.Note,
                    Source = interview.Source,
                    URL = interview.URL
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Presentation presentation)
        {
            if (presentation != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Presentation,
                    TitleFull = presentation.TitleFull,
                    TitleShort = presentation.TitleShort,
                    Authors = presentation.Creators != null ? presentation.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = presentation.Creators != null ? presentation.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherLocation = presentation.PublisherLocation,
                    EventName = presentation.EventName,
                    EventPlace = presentation.EventPlace,
                    Abstract = presentation.Abstract,
                    AccessedDate = new PM.DateInformation(presentation.AccessedDate),
                    Genre = presentation.Genre,
                    IssuedDate = new PM.DateInformation(presentation.IssuedDate),
                    Language = presentation.Language,
                    Note = presentation.Note,
                    URL = presentation.URL
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Map map)
        {
            if (map != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Map,
                    TitleFull = map.TitleFull,
                    TitleShort = map.TitleShort,
                    Authors = map.Creators != null ? map.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = map.Creators != null ? map.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherName = map.PublisherName,
                    PublisherLocation = map.PublisherLocation,
                    CollectionTitle = map.CollectionTitle,
                    CollectionEditors = map.Creators != null ? map.Creators.Where(x => x.Type == DE.CreatorType.CollectionEditor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ArchiveName = map.ArchiveName,
                    ArchiveLocation = map.ArchiveLocation,
                    EventPlace = map.EventPlace,
                    ISBN = map.ISBN,
                    Abstract = map.Abstract,
                    AccessedDate = new PM.DateInformation(map.AccessedDate),
                    CallNumber = map.CallNumber,
                    Edition = map.Edition,
                    Genre = map.Genre,
                    IssuedDate = new PM.DateInformation(map.IssuedDate),
                    Language = map.Language,
                    Note = map.Note,
                    Scale = map.Scale,
                    Source = map.Source,
                    URL = map.URL
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Bill bill)
        {
            if (bill != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Bill,
                    TitleFull = bill.TitleFull,
                    TitleShort = bill.TitleShort,
                    Authors = bill.Creators != null ? bill.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = bill.Creators != null ? bill.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ContainerTitleFull = bill.ContainerTitle,
                    PageNumber = bill.PageNumber,
                    Abstract = bill.Abstract,
                    AccessedDate = new PM.DateInformation(bill.AccessedDate),
                    Authority = bill.Authority,
                    ChapterNumber = bill.ChapterNumber,
                    IssuedDate = new PM.DateInformation(bill.IssuedDate),
                    Language = bill.Language,
                    Note = bill.Note,
                    Number = bill.Number,
                    References = bill.References,
                    Section = bill.Section,
                    URL = bill.URL,
                    VolumeNumber = bill.VolumeNumber
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Legislation legislation)
        {
            if (legislation != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Legislation,
                    TitleFull = legislation.TitleFull,
                    TitleShort = legislation.TitleShort,
                    Authors = legislation.Creators != null ? legislation.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = legislation.Creators != null ? legislation.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ContainerTitleFull = legislation.ContainerTitle,
                    PageNumber = legislation.PageNumber,
                    Abstract = legislation.Abstract,
                    AccessedDate = new PM.DateInformation(legislation.AccessedDate),
                    ChapterNumber = legislation.ChapterNumber,
                    IssuedDate = new PM.DateInformation(legislation.IssuedDate),
                    Language = legislation.Language,
                    Note = legislation.Note,
                    Number = legislation.Number,
                    References = legislation.References,
                    Section = legislation.Section,
                    URL = legislation.URL,
                    VolumeNumber = legislation.VolumeNumber
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.LegalCase legalCase)
        {
            if (legalCase != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.LegalCase,
                    TitleFull = legalCase.TitleFull,
                    TitleShort = legalCase.TitleShort,
                    Authors = legalCase.Creators != null ? legalCase.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = legalCase.Creators != null ? legalCase.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ContainerTitleFull = legalCase.ContainerTitle,
                    PageNumber = legalCase.PageNumber,
                    Abstract = legalCase.Abstract,
                    AccessedDate = new PM.DateInformation(legalCase.AccessedDate),
                    Authority = legalCase.Authority,
                    IssuedDate = new PM.DateInformation(legalCase.IssuedDate),
                    Language = legalCase.Language,
                    Note = legalCase.Note,
                    Number = legalCase.Number,
                    References = legalCase.References,
                    URL = legalCase.URL,
                    VolumeNumber = legalCase.VolumeNumber
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.Report report)
        {
            if (report != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.Report,
                    TitleFull = report.TitleFull,
                    TitleShort = report.TitleShort,
                    Authors = report.Creators != null ? report.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = report.Creators != null ? report.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherName = report.PublisherName,
                    PublisherLocation = report.PublisherLocation,
                    CollectionTitle = report.CollectionTitle,
                    CollectionEditors = report.Creators != null ? report.Creators.Where(x => x.Type == DE.CreatorType.CollectionEditor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ArchiveName = report.ArchiveName,
                    ArchiveLocation = report.ArchiveLocation,
                    PageNumber = report.PageNumber,
                    EventPlace = report.EventPlace,
                    Abstract = report.Abstract,
                    AccessedDate = new PM.DateInformation(report.AccessedDate),
                    CallNumber = report.CallNumber,
                    Genre = report.Genre,
                    IssuedDate = new PM.DateInformation(report.IssuedDate),
                    Language = report.Language,
                    Note = report.Note,
                    Number = report.Number,
                    Source = report.Source,
                    URL = report.URL
                };
            }
            else
            {
                return null;
            }
        }

        internal static PM.ContentItem Build(string id, DM.ConferencePaper conferencePaper)
        {
            if (conferencePaper != null)
            {
                return new PM.ContentItem()
                {
                    ID = id,
                    ItemTypeValue = PE.ItemType.ConferencePaper,
                    TitleFull = conferencePaper.TitleFull,
                    TitleShort = conferencePaper.TitleShort,
                    Authors = conferencePaper.Creators != null ? conferencePaper.Creators.Where(x => x.Type == DE.CreatorType.Author).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Editors = conferencePaper.Creators != null ? conferencePaper.Creators.Where(x => x.Type == DE.CreatorType.Editor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    Translators = conferencePaper.Creators != null ? conferencePaper.Creators.Where(x => x.Type == DE.CreatorType.Translator).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    PublisherName = conferencePaper.PublisherName,
                    PublisherLocation = conferencePaper.PublisherLocation,
                    ContainerTitleFull = conferencePaper.ContainerTitle,
                    CollectionTitle = conferencePaper.CollectionTitle,
                    CollectionEditors = conferencePaper.Creators != null ? conferencePaper.Creators.Where(x => x.Type == DE.CreatorType.CollectionEditor).Select(x => Build(x)).ToList() : new List<PM.Creator>(),
                    ArchiveName = conferencePaper.ArchiveName,
                    ArchiveLocation = conferencePaper.ArchiveLocation,
                    PageNumber = conferencePaper.PageNumber,
                    EventName = conferencePaper.EventName,
                    EventPlace = conferencePaper.EventPlace,
                    ISBN = conferencePaper.ISBN,
                    DOI = conferencePaper.DOI,
                    Abstract = conferencePaper.Abstract,
                    AccessedDate = new PM.DateInformation(conferencePaper.AccessedDate),
                    CallNumber = conferencePaper.CallNumber,
                    IssuedDate = new PM.DateInformation(conferencePaper.IssuedDate),
                    Language = conferencePaper.Language,
                    Note = conferencePaper.Note,
                    Source = conferencePaper.Source,
                    URL = conferencePaper.URL,
                    VolumeNumber = conferencePaper.VolumeNumber
                };
            }
            else
            {
                return null;
            }
        }

        private static PM.Creator Build(DM.Creator creator)
        {
            if (creator != null)
            {
                return new PM.Creator()
                {
                    Full = creator.Full,
                    Given = creator.Given,
                    Family = creator.Family,
                    ParticleDropping = creator.ParticleDropping,
                    ParticleNonDropping = creator.ParticleNonDropping,
                    Suffix = creator.Suffix
                };
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Methods - Library To Domain

        internal static DM.Bibliography Build(PM.Bibliography bibliography)
        {
            if (bibliography != null)
            {
                return new DM.Bibliography()
                {
                    SpacingEntry = bibliography.MetaData != null ? bibliography.MetaData.SpacingEntry : 0,
                    SpacingLine = bibliography.MetaData != null ? bibliography.MetaData.SpacingLine : 0,
                    HangingIndent = bibliography.MetaData != null ? bibliography.MetaData.HangingIndent : false,
                    Values = bibliography.Values
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Citation Build(PM.Citation citation)
        {
            if (citation != null)
            {
                return new DM.Citation()
                {
                    Value = citation.Value
                };
            }
            else
            {
                return null;
            }
        }

        #endregion

    }

}