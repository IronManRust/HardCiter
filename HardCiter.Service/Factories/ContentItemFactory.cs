using System;
using System.Collections.Generic;
using System.Linq;
using DE = HardCiter.Domain.Enums;
using DM = HardCiter.Domain.Models;
using SE = HardCiter.Service.Enums;
using SM = HardCiter.Service.Models;

namespace HardCiter.Service.Factories
{

    internal static class ContentItemFactory
    {

        #region Methods - Service To Domain

        internal static DE.Style Build(SE.Style style)
        {
            switch (style)
            {
                case SE.Style.Unknown:
                    return DE.Style.Unknown;
                case SE.Style.MLA7:
                    return DE.Style.MLA7;
                case SE.Style.MLA8:
                    return DE.Style.MLA8;
                case SE.Style.APA5:
                    return DE.Style.APA5;
                case SE.Style.APA6:
                    return DE.Style.APA6;
                case SE.Style.APA7:
                    return DE.Style.APA7;
                case SE.Style.Chicago17:
                    return DE.Style.Chicago17;
                case SE.Style.Harvard10:
                    return DE.Style.Harvard10;
                case SE.Style.ASA6:
                    return DE.Style.ASA6;
                case SE.Style.Turabian8:
                    return DE.Style.Turabian8;
                default:
                    throw new NotImplementedException();
            }
        }

        internal static DE.Format Build(SE.Format format)
        {
            switch (format)
            {
                case SE.Format.Unknown:
                    return DE.Format.Unknown;
                case SE.Format.Text:
                    return DE.Format.Text;
                case SE.Format.HTML:
                    return DE.Format.HTML;
                default:
                    throw new NotImplementedException();
            }
        }

        internal static DM.ContentItem Build(SM.ContentItem contentItem)
        {
            if (contentItem != null)
            {
                switch (contentItem.ItemType)
                {
                    case SE.ItemType.Unknown:
                        throw new ArgumentException("Invalid ItemType");
                    case SE.ItemType.Book:
                        return Build(contentItem as SM.Book);
                    case SE.ItemType.Chapter:
                        return Build(contentItem as SM.Chapter);
                    case SE.ItemType.Journal:
                        return Build(contentItem as SM.Journal);
                    case SE.ItemType.Magazine:
                        return Build(contentItem as SM.Magazine);
                    case SE.ItemType.Newspaper:
                        return Build(contentItem as SM.Newspaper);
                    case SE.ItemType.Webpage:
                        return Build(contentItem as SM.Webpage);
                    case SE.ItemType.Encyclopedia:
                        return Build(contentItem as SM.Encyclopedia);
                    case SE.ItemType.Graphic:
                        return Build(contentItem as SM.Graphic);
                    case SE.ItemType.AudioRecording:
                        return Build(contentItem as SM.AudioRecording);
                    case SE.ItemType.VideoRecording:
                        return Build(contentItem as SM.VideoRecording);
                    case SE.ItemType.Broadcast:
                        return Build(contentItem as SM.Broadcast);
                    case SE.ItemType.PersonalCommunication:
                        return Build(contentItem as SM.PersonalCommunication);
                    case SE.ItemType.Interview:
                        return Build(contentItem as SM.Interview);
                    case SE.ItemType.Presentation:
                        return Build(contentItem as SM.Presentation);
                    case SE.ItemType.Map:
                        return Build(contentItem as SM.Map);
                    case SE.ItemType.Bill:
                        return Build(contentItem as SM.Bill);
                    case SE.ItemType.Legislation:
                        return Build(contentItem as SM.Legislation);
                    case SE.ItemType.LegalCase:
                        return Build(contentItem as SM.LegalCase);
                    case SE.ItemType.Report:
                        return Build(contentItem as SM.Report);
                    case SE.ItemType.ConferencePaper:
                        return Build(contentItem as SM.ConferencePaper);
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                return null;
            }
        }

        internal static DM.Book Build(SM.Book book)
        {
            if (book != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(book.Authors != null ? book.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(book.Translators != null ? book.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(book.Editors != null ? book.Editors.Select(x => Build(x, DE.CreatorType.Editor)).ToList() : new List<DM.Creator>());
                creators.AddRange(book.CollectionEditors != null ? book.CollectionEditors.Select(x => Build(x, DE.CreatorType.CollectionEditor)).ToList() : new List<DM.Creator>());
                return new DM.Book()
                {
                    TitleFull = book.TitleFull,
                    TitleShort = book.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(book.AccessedDate),
                    IssuedDate = Build(book.IssuedDate),
                    Abstract = book.Abstract,
                    Language = book.Language,
                    Note = book.Note,
                    URL = book.URL,
                    PublisherName = book.PublisherName,
                    PublisherLocation = book.PublisherLocation,
                    ISBN = book.ISBN,
                    CallNumber = book.CallNumber,
                    ArchiveName = book.ArchiveName,
                    ArchiveLocation = book.ArchiveLocation,
                    CollectionTitle = book.CollectionTitle,
                    CollectionNumber = book.CollectionNumber,
                    Edition = book.Edition,
                    VolumeNumber = book.VolumeNumber,
                    VolumeCount = book.VolumeCount,
                    Source = book.Source,
                    EventPlace = book.EventPlace,
                    PageCount = book.PageCount
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Chapter Build(SM.Chapter chapter)
        {
            if (chapter != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(chapter.Authors != null ? chapter.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(chapter.Translators != null ? chapter.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(chapter.Editors != null ? chapter.Editors.Select(x => Build(x, DE.CreatorType.Editor)).ToList() : new List<DM.Creator>());
                creators.AddRange(chapter.CollectionEditors != null ? chapter.CollectionEditors.Select(x => Build(x, DE.CreatorType.CollectionEditor)).ToList() : new List<DM.Creator>());
                creators.AddRange(chapter.ContainerAuthors != null ? chapter.ContainerAuthors.Select(x => Build(x, DE.CreatorType.ContainerAuthor)).ToList() : new List<DM.Creator>());
                return new DM.Chapter()
                {
                    TitleFull = chapter.TitleFull,
                    TitleShort = chapter.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(chapter.AccessedDate),
                    IssuedDate = Build(chapter.IssuedDate),
                    Abstract = chapter.Abstract,
                    Language = chapter.Language,
                    Note = chapter.Note,
                    URL = chapter.URL,
                    PublisherName = chapter.PublisherName,
                    PublisherLocation = chapter.PublisherLocation,
                    ISBN = chapter.ISBN,
                    CallNumber = chapter.CallNumber,
                    ArchiveName = chapter.ArchiveName,
                    ArchiveLocation = chapter.ArchiveLocation,
                    CollectionTitle = chapter.CollectionTitle,
                    CollectionNumber = chapter.CollectionNumber,
                    Edition = chapter.Edition,
                    VolumeNumber = chapter.VolumeNumber,
                    VolumeCount = chapter.VolumeCount,
                    Source = chapter.Source,
                    EventPlace = chapter.EventPlace,
                    ContainerTitle = chapter.ContainerTitle,
                    PageNumber = chapter.PageNumber
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Journal Build(SM.Journal journal)
        {
            if (journal != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(journal.Authors != null ? journal.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(journal.Translators != null ? journal.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(journal.ReviewedAuthors != null ? journal.ReviewedAuthors.Select(x => Build(x, DE.CreatorType.ReviewedAuthor)).ToList() : new List<DM.Creator>());
                creators.AddRange(journal.Editors != null ? journal.Editors.Select(x => Build(x, DE.CreatorType.Editor)).ToList() : new List<DM.Creator>());
                return new DM.Journal()
                {
                    TitleFull = journal.TitleFull,
                    TitleShort = journal.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(journal.AccessedDate),
                    IssuedDate = Build(journal.IssuedDate),
                    Abstract = journal.Abstract,
                    Language = journal.Language,
                    Note = journal.Note,
                    URL = journal.URL,
                    ISSN = journal.ISSN,
                    CallNumber = journal.CallNumber,
                    ArchiveName = journal.ArchiveName,
                    ArchiveLocation = journal.ArchiveLocation,
                    ContainerTitleFull = journal.ContainerTitleFull,
                    ContainerTitleShort = journal.ContainerTitleShort,
                    PageNumber = journal.PageNumber,
                    Source = journal.Source,
                    CollectionTitle = journal.CollectionTitle,
                    DOI = journal.DOI,
                    Issue = journal.Issue,
                    Volume = journal.Volume
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Magazine Build(SM.Magazine magazine)
        {
            if (magazine != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(magazine.Authors != null ? magazine.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(magazine.Translators != null ? magazine.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(magazine.ReviewedAuthors != null ? magazine.ReviewedAuthors.Select(x => Build(x, DE.CreatorType.ReviewedAuthor)).ToList() : new List<DM.Creator>());
                return new DM.Magazine()
                {
                    TitleFull = magazine.TitleFull,
                    TitleShort = magazine.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(magazine.AccessedDate),
                    IssuedDate = Build(magazine.IssuedDate),
                    Abstract = magazine.Abstract,
                    Language = magazine.Language,
                    Note = magazine.Note,
                    URL = magazine.URL,
                    ISSN = magazine.ISSN,
                    CallNumber = magazine.CallNumber,
                    ArchiveName = magazine.ArchiveName,
                    ArchiveLocation = magazine.ArchiveLocation,
                    ContainerTitleFull = magazine.ContainerTitleFull,
                    PageNumber = magazine.PageNumber,
                    Source = magazine.Source,
                    Volume = magazine.Volume,
                    Issue = magazine.Issue
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Newspaper Build(SM.Newspaper newspaper)
        {
            if (newspaper != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(newspaper.Authors != null ? newspaper.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(newspaper.Translators != null ? newspaper.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(newspaper.ReviewedAuthors != null ? newspaper.ReviewedAuthors.Select(x => Build(x, DE.CreatorType.ReviewedAuthor)).ToList() : new List<DM.Creator>());
                return new DM.Newspaper()
                {
                    TitleFull = newspaper.TitleFull,
                    TitleShort = newspaper.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(newspaper.AccessedDate),
                    IssuedDate = Build(newspaper.IssuedDate),
                    Abstract = newspaper.Abstract,
                    Language = newspaper.Language,
                    Note = newspaper.Note,
                    URL = newspaper.URL,
                    ISSN = newspaper.ISSN,
                    CallNumber = newspaper.CallNumber,
                    ArchiveName = newspaper.ArchiveName,
                    ArchiveLocation = newspaper.ArchiveLocation,
                    ContainerTitleFull = newspaper.ContainerTitleFull,
                    PageNumber = newspaper.PageNumber,
                    Source = newspaper.Source,
                    PublisherLocation = newspaper.PublisherLocation,
                    EventPlace = newspaper.EventPlace,
                    Edition = newspaper.Edition,
                    Section = newspaper.Section
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Webpage Build(SM.Webpage webpage)
        {
            if (webpage != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(webpage.Authors != null ? webpage.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(webpage.Translators != null ? webpage.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                return new DM.Webpage()
                {
                    TitleFull = webpage.TitleFull,
                    TitleShort = webpage.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(webpage.AccessedDate),
                    IssuedDate = Build(webpage.IssuedDate),
                    Abstract = webpage.Abstract,
                    Language = webpage.Language,
                    Note = webpage.Note,
                    URL = webpage.URL,
                    ContainerTitle = webpage.ContainerTitle,
                    Genre = webpage.Genre
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Encyclopedia Build(SM.Encyclopedia encyclopedia)
        {
            if (encyclopedia != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(encyclopedia.Authors != null ? encyclopedia.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(encyclopedia.Translators != null ? encyclopedia.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(encyclopedia.Editors != null ? encyclopedia.Editors.Select(x => Build(x, DE.CreatorType.Editor)).ToList() : new List<DM.Creator>());
                creators.AddRange(encyclopedia.CollectionEditors != null ? encyclopedia.CollectionEditors.Select(x => Build(x, DE.CreatorType.CollectionEditor)).ToList() : new List<DM.Creator>());
                return new DM.Encyclopedia()
                {
                    TitleFull = encyclopedia.TitleFull,
                    TitleShort = encyclopedia.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(encyclopedia.AccessedDate),
                    IssuedDate = Build(encyclopedia.IssuedDate),
                    Abstract = encyclopedia.Abstract,
                    Language = encyclopedia.Language,
                    Note = encyclopedia.Note,
                    URL = encyclopedia.URL,
                    PublisherName = encyclopedia.PublisherName,
                    PublisherLocation = encyclopedia.PublisherLocation,
                    ISBN = encyclopedia.ISBN,
                    CallNumber = encyclopedia.CallNumber,
                    ArchiveName = encyclopedia.ArchiveName,
                    ArchiveLocation = encyclopedia.ArchiveLocation,
                    CollectionTitle = encyclopedia.CollectionTitle,
                    CollectionNumber = encyclopedia.CollectionNumber,
                    ContainerTitle = encyclopedia.ContainerTitle,
                    PageNumber = encyclopedia.PageNumber,
                    Edition = encyclopedia.Edition,
                    VolumeNumber = encyclopedia.VolumeNumber,
                    VolumeCount = encyclopedia.VolumeCount,
                    Source = encyclopedia.Source,
                    EventPlace = encyclopedia.EventPlace
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Graphic Build(SM.Graphic graphic)
        {
            if (graphic != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(graphic.Authors != null ? graphic.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(graphic.Translators != null ? graphic.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                return new DM.Graphic()
                {
                    TitleFull = graphic.TitleFull,
                    TitleShort = graphic.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(graphic.AccessedDate),
                    IssuedDate = Build(graphic.IssuedDate),
                    Abstract = graphic.Abstract,
                    Language = graphic.Language,
                    Note = graphic.Note,
                    URL = graphic.URL,
                    ArchiveName = graphic.ArchiveName,
                    ArchiveLocation = graphic.ArchiveLocation,
                    CallNumber = graphic.CallNumber,
                    Dimensions = graphic.Dimensions,
                    Medium = graphic.Medium,
                    Source = graphic.Source
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.AudioRecording Build(SM.AudioRecording audioRecording)
        {
            if (audioRecording != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(audioRecording.Authors != null ? audioRecording.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(audioRecording.Translators != null ? audioRecording.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(audioRecording.Composers != null ? audioRecording.Composers.Select(x => Build(x, DE.CreatorType.Composer)).ToList() : new List<DM.Creator>());
                return new DM.AudioRecording()
                {
                    TitleFull = audioRecording.TitleFull,
                    TitleShort = audioRecording.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(audioRecording.AccessedDate),
                    IssuedDate = Build(audioRecording.IssuedDate),
                    Abstract = audioRecording.Abstract,
                    Language = audioRecording.Language,
                    Note = audioRecording.Note,
                    URL = audioRecording.URL,
                    ArchiveName = audioRecording.ArchiveName,
                    ArchiveLocation = audioRecording.ArchiveLocation,
                    CallNumber = audioRecording.CallNumber,
                    Dimensions = audioRecording.Dimensions,
                    Medium = audioRecording.Medium,
                    Source = audioRecording.Source,
                    CollectionTitle = audioRecording.CollectionTitle,
                    EventPlace = audioRecording.EventPlace,
                    ISBN = audioRecording.ISBN,
                    VolumeNumber = audioRecording.VolumeNumber,
                    VolumeCount = audioRecording.VolumeCount,
                    PublisherName = audioRecording.PublisherName,
                    PublisherLocation = audioRecording.PublisherLocation
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.VideoRecording Build(SM.VideoRecording videoRecording)
        {
            if (videoRecording != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(videoRecording.Authors != null ? videoRecording.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(videoRecording.Translators != null ? videoRecording.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                return new DM.VideoRecording()
                {
                    TitleFull = videoRecording.TitleFull,
                    TitleShort = videoRecording.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(videoRecording.AccessedDate),
                    IssuedDate = Build(videoRecording.IssuedDate),
                    Abstract = videoRecording.Abstract,
                    Language = videoRecording.Language,
                    Note = videoRecording.Note,
                    URL = videoRecording.URL,
                    ArchiveName = videoRecording.ArchiveName,
                    ArchiveLocation = videoRecording.ArchiveLocation,
                    CallNumber = videoRecording.CallNumber,
                    Dimensions = videoRecording.Dimensions,
                    Medium = videoRecording.Medium,
                    Source = videoRecording.Source,
                    CollectionTitle = videoRecording.CollectionTitle,
                    EventPlace = videoRecording.EventPlace,
                    ISBN = videoRecording.ISBN,
                    VolumeNumber = videoRecording.VolumeNumber,
                    VolumeCount = videoRecording.VolumeCount,
                    PublisherName = videoRecording.PublisherName,
                    PublisherLocation = videoRecording.PublisherLocation
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Broadcast Build(SM.Broadcast broadcast)
        {
            if (broadcast != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(broadcast.Authors != null ? broadcast.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(broadcast.Translators != null ? broadcast.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                return new DM.Broadcast()
                {
                    TitleFull = broadcast.TitleFull,
                    TitleShort = broadcast.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(broadcast.AccessedDate),
                    IssuedDate = Build(broadcast.IssuedDate),
                    Abstract = broadcast.Abstract,
                    Language = broadcast.Language,
                    Note = broadcast.Note,
                    URL = broadcast.URL,
                    ArchiveName = broadcast.ArchiveName,
                    ArchiveLocation = broadcast.ArchiveLocation,
                    CallNumber = broadcast.CallNumber,
                    Dimensions = broadcast.Dimensions,
                    Medium = broadcast.Medium,
                    Source = broadcast.Source,
                    ContainerTitle = broadcast.ContainerTitle,
                    Number = broadcast.Number,
                    EventPlace = broadcast.EventPlace,
                    PublisherName = broadcast.PublisherName,
                    PublisherLocation = broadcast.PublisherLocation
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.PersonalCommunication Build(SM.PersonalCommunication personalCommunication)
        {
            if (personalCommunication != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(personalCommunication.Authors != null ? personalCommunication.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(personalCommunication.Translators != null ? personalCommunication.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(personalCommunication.Recipients != null ? personalCommunication.Recipients.Select(x => Build(x, DE.CreatorType.Recipient)).ToList() : new List<DM.Creator>());
                return new DM.PersonalCommunication()
                {
                    TitleFull = personalCommunication.TitleFull,
                    TitleShort = personalCommunication.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(personalCommunication.AccessedDate),
                    IssuedDate = Build(personalCommunication.IssuedDate),
                    Abstract = personalCommunication.Abstract,
                    Language = personalCommunication.Language,
                    Note = personalCommunication.Note,
                    URL = personalCommunication.URL,
                    CallNumber = personalCommunication.CallNumber,
                    ArchiveName = personalCommunication.ArchiveName,
                    ArchiveLocation = personalCommunication.ArchiveLocation,
                    Genre = personalCommunication.Genre,
                    Source = personalCommunication.Source
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Interview Build(SM.Interview interview)
        {
            if (interview != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(interview.Authors != null ? interview.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(interview.Translators != null ? interview.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(interview.Interviewers != null ? interview.Interviewers.Select(x => Build(x, DE.CreatorType.Interviewer)).ToList() : new List<DM.Creator>());
                return new DM.Interview()
                {
                    TitleFull = interview.TitleFull,
                    TitleShort = interview.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(interview.AccessedDate),
                    IssuedDate = Build(interview.IssuedDate),
                    Abstract = interview.Abstract,
                    Language = interview.Language,
                    Note = interview.Note,
                    URL = interview.URL,
                    CallNumber = interview.CallNumber,
                    ArchiveName = interview.ArchiveName,
                    ArchiveLocation = interview.ArchiveLocation,
                    Medium = interview.Medium,
                    Source = interview.Source
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Presentation Build(SM.Presentation presentation)
        {
            if (presentation != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(presentation.Authors != null ? presentation.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(presentation.Translators != null ? presentation.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                return new DM.Presentation()
                {
                    TitleFull = presentation.TitleFull,
                    TitleShort = presentation.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(presentation.AccessedDate),
                    IssuedDate = Build(presentation.IssuedDate),
                    Abstract = presentation.Abstract,
                    Language = presentation.Language,
                    Note = presentation.Note,
                    URL = presentation.URL,
                    PublisherLocation = presentation.PublisherLocation,
                    EventName = presentation.EventName,
                    EventPlace = presentation.EventPlace,
                    Genre = presentation.Genre
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Map Build(SM.Map map)
        {
            if (map != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(map.Authors != null ? map.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(map.Translators != null ? map.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(map.CollectionEditors != null ? map.CollectionEditors.Select(x => Build(x, DE.CreatorType.CollectionEditor)).ToList() : new List<DM.Creator>());
                return new DM.Map()
                {
                    TitleFull = map.TitleFull,
                    TitleShort = map.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(map.AccessedDate),
                    IssuedDate = Build(map.IssuedDate),
                    Abstract = map.Abstract,
                    Language = map.Language,
                    Note = map.Note,
                    URL = map.URL,
                    PublisherName = map.PublisherName,
                    PublisherLocation = map.PublisherLocation,
                    ISBN = map.ISBN,
                    CallNumber = map.CallNumber,
                    ArchiveName = map.ArchiveName,
                    ArchiveLocation = map.ArchiveLocation,
                    CollectionTitle = map.CollectionTitle,
                    Edition = map.Edition,
                    Genre = map.Genre,
                    Source = map.Source,
                    EventPlace = map.EventPlace,
                    Scale = map.Scale
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Bill Build(SM.Bill bill)
        {
            if (bill != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(bill.Authors != null ? bill.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(bill.Translators != null ? bill.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                return new DM.Bill()
                {
                    TitleFull = bill.TitleFull,
                    TitleShort = bill.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(bill.AccessedDate),
                    IssuedDate = Build(bill.IssuedDate),
                    Abstract = bill.Abstract,
                    Language = bill.Language,
                    Note = bill.Note,
                    URL = bill.URL,
                    ContainerTitle = bill.ContainerTitle,
                    PageNumber = bill.PageNumber,
                    Number = bill.Number,
                    References = bill.References,
                    VolumeNumber = bill.VolumeNumber,
                    Authority = bill.Authority,
                    ChapterNumber = bill.ChapterNumber,
                    Section = bill.Section
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Legislation Build(SM.Legislation legislation)
        {
            if (legislation != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(legislation.Authors != null ? legislation.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(legislation.Translators != null ? legislation.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                return new DM.Legislation()
                {
                    TitleFull = legislation.TitleFull,
                    TitleShort = legislation.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(legislation.AccessedDate),
                    IssuedDate = Build(legislation.IssuedDate),
                    Abstract = legislation.Abstract,
                    Language = legislation.Language,
                    Note = legislation.Note,
                    URL = legislation.URL,
                    ContainerTitle = legislation.ContainerTitle,
                    PageNumber = legislation.PageNumber,
                    Number = legislation.Number,
                    References = legislation.References,
                    VolumeNumber = legislation.VolumeNumber,
                    ChapterNumber = legislation.ChapterNumber,
                    Section = legislation.Section
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.LegalCase Build(SM.LegalCase legalCase)
        {
            if (legalCase != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(legalCase.Authors != null ? legalCase.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(legalCase.Translators != null ? legalCase.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                return new DM.LegalCase()
                {
                    TitleFull = legalCase.TitleFull,
                    TitleShort = legalCase.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(legalCase.AccessedDate),
                    IssuedDate = Build(legalCase.IssuedDate),
                    Abstract = legalCase.Abstract,
                    Language = legalCase.Language,
                    Note = legalCase.Note,
                    URL = legalCase.URL,
                    ContainerTitle = legalCase.ContainerTitle,
                    PageNumber = legalCase.PageNumber,
                    Number = legalCase.Number,
                    References = legalCase.References,
                    VolumeNumber = legalCase.VolumeNumber,
                    Authority = legalCase.Authority
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.Report Build(SM.Report report)
        {
            if (report != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(report.Authors != null ? report.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(report.Translators != null ? report.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(report.CollectionEditors != null ? report.CollectionEditors.Select(x => Build(x, DE.CreatorType.CollectionEditor)).ToList() : new List<DM.Creator>());
                return new DM.Report()
                {
                    TitleFull = report.TitleFull,
                    TitleShort = report.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(report.AccessedDate),
                    IssuedDate = Build(report.IssuedDate),
                    Abstract = report.Abstract,
                    Language = report.Language,
                    Note = report.Note,
                    URL = report.URL,
                    PublisherName = report.PublisherName,
                    PublisherLocation = report.PublisherLocation,
                    CallNumber = report.CallNumber,
                    ArchiveName = report.ArchiveName,
                    ArchiveLocation = report.ArchiveLocation,
                    CollectionTitle = report.CollectionTitle,
                    PageNumber = report.PageNumber,
                    Source = report.Source,
                    EventPlace = report.EventPlace,
                    Number = report.Number,
                    Genre = report.Genre
                };
            }
            else
            {
                return null;
            }
        }

        internal static DM.ConferencePaper Build(SM.ConferencePaper conferencePaper)
        {
            if (conferencePaper != null)
            {
                List<DM.Creator> creators = new List<DM.Creator>();
                creators.AddRange(conferencePaper.Authors != null ? conferencePaper.Authors.Select(x => Build(x, DE.CreatorType.Author)).ToList() : new List<DM.Creator>());
                creators.AddRange(conferencePaper.Translators != null ? conferencePaper.Translators.Select(x => Build(x, DE.CreatorType.Translator)).ToList() : new List<DM.Creator>());
                creators.AddRange(conferencePaper.Editors != null ? conferencePaper.Editors.Select(x => Build(x, DE.CreatorType.Editor)).ToList() : new List<DM.Creator>());
                creators.AddRange(conferencePaper.CollectionEditors != null ? conferencePaper.CollectionEditors.Select(x => Build(x, DE.CreatorType.CollectionEditor)).ToList() : new List<DM.Creator>());
                return new DM.ConferencePaper()
                {
                    TitleFull = conferencePaper.TitleFull,
                    TitleShort = conferencePaper.TitleShort,
                    Creators = creators,
                    AccessedDate = Build(conferencePaper.AccessedDate),
                    IssuedDate = Build(conferencePaper.IssuedDate),
                    Abstract = conferencePaper.Abstract,
                    Language = conferencePaper.Language,
                    Note = conferencePaper.Note,
                    URL = conferencePaper.URL,
                    PublisherName = conferencePaper.PublisherName,
                    PublisherLocation = conferencePaper.PublisherLocation,
                    CallNumber = conferencePaper.CallNumber,
                    ArchiveName = conferencePaper.ArchiveName,
                    ArchiveLocation = conferencePaper.ArchiveLocation,
                    CollectionTitle = conferencePaper.CollectionTitle,
                    PageNumber = conferencePaper.PageNumber,
                    Source = conferencePaper.Source,
                    EventPlace = conferencePaper.EventPlace,
                    ISBN = conferencePaper.ISBN,
                    DOI = conferencePaper.DOI,
                    ContainerTitle = conferencePaper.ContainerTitle,
                    EventName = conferencePaper.EventName,
                    VolumeNumber = conferencePaper.VolumeNumber
                };
            }
            else
            {
                return null;
            }
        }

        private static DM.Creator Build(SM.Creator creator, DE.CreatorType creatorType)
        {
            if (creator != null)
            {
                return new DM.Creator()
                {
                    Type = creatorType,
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

        private static DM.DateInformation Build(SM.DateInformation dateInformation)
        {
            if (dateInformation != null)
            {
                return new DM.DateInformation()
                {
                    DateType = Build(dateInformation.DateType),
                    DateExact = dateInformation.DateExact,
                    Year = dateInformation.Year,
                    Month = dateInformation.Month,
                    Day = dateInformation.Day,
                    Season = dateInformation.Season,
                    IsApproximate = dateInformation.IsApproximate,
                    DateMin = dateInformation.DateMin,
                    DateMax = dateInformation.DateMax,
                    YearMin = dateInformation.YearMin,
                    YearMax = dateInformation.YearMax,
                    MonthMin = dateInformation.MonthMin,
                    MonthMax = dateInformation.MonthMax,
                    DayMin = dateInformation.DayMin,
                    DayMax = dateInformation.DayMax,
                    Literal = dateInformation.Literal
                };
            }
            else
            {
                return null;
            }
        }

        private static DE.DateType Build(SE.DateType dateType)
        {
            switch (dateType)
            {
                case SE.DateType.Unknown:
                    return DE.DateType.Unknown;
                case SE.DateType.ExactFull:
                    return DE.DateType.ExactFull;
                case SE.DateType.ExactPartial:
                    return DE.DateType.ExactPartial;
                case SE.DateType.RangeFull:
                    return DE.DateType.RangeFull;
                case SE.DateType.RangePartial:
                    return DE.DateType.RangePartial;
                case SE.DateType.Literal:
                    return DE.DateType.Literal;
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion

        #region Methods - Domain To Service

        internal static SM.Bibliography Build(DM.Bibliography bibliography)
        {
            if (bibliography != null)
            {
                return new SM.Bibliography()
                {
                    SpacingEntry = bibliography.SpacingEntry,
                    SpacingLine = bibliography.SpacingLine,
                    HangingIndent = bibliography.HangingIndent,
                    Values = bibliography.Values
                };
            }
            else
            {
                return null;
            }
        }

        internal static SM.Citation Build(DM.Citation citation)
        {
            if (citation != null)
            {
                return new SM.Citation()
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