using System;
using System.Collections.Generic;
using System.Linq;
using DE = HardCiter.Domain.Enums;
using DI = HardCiter.Domain.Interfaces;
using DM = HardCiter.Domain.Models;

namespace HardCiter.API
{

    public class BibliographyProcessor : BaseProcessor
    {

        #region Variables

        private DI.IBibliographyProcessor _bibliographyProcessor;

        #endregion

        #region Constructors

        public BibliographyProcessor(DI.IBibliographyProcessor bibliographyProcessor, IEnumerable<DI.IRule<DM.Book>> rulesBook, IEnumerable<DI.IRule<DM.Chapter>> rulesChapter, IEnumerable<DI.IRule<DM.Journal>> rulesJournal, IEnumerable<DI.IRule<DM.Magazine>> rulesMagazine, IEnumerable<DI.IRule<DM.Newspaper>> rulesNewspaper, IEnumerable<DI.IRule<DM.Webpage>> rulesWebpage, IEnumerable<DI.IRule<DM.Encyclopedia>> rulesEncyclopedia, IEnumerable<DI.IRule<DM.Graphic>> rulesGraphic, IEnumerable<DI.IRule<DM.AudioRecording>> rulesAudioRecording, IEnumerable<DI.IRule<DM.VideoRecording>> rulesVideoRecording, IEnumerable<DI.IRule<DM.Broadcast>> rulesBroadcast, IEnumerable<DI.IRule<DM.PersonalCommunication>> rulesPersonalCommunication, IEnumerable<DI.IRule<DM.Interview>> rulesInterview, IEnumerable<DI.IRule<DM.Presentation>> rulesPresentation, IEnumerable<DI.IRule<DM.Map>> rulesMap, IEnumerable<DI.IRule<DM.Bill>> rulesBill, IEnumerable<DI.IRule<DM.Legislation>> rulesLegislation, IEnumerable<DI.IRule<DM.LegalCase>> rulesLegalCase, IEnumerable<DI.IRule<DM.Report>> rulesReport, IEnumerable<DI.IRule<DM.ConferencePaper>> rulesConferencePaper) : base(rulesBook, rulesChapter, rulesJournal, rulesMagazine, rulesNewspaper, rulesWebpage, rulesEncyclopedia, rulesGraphic, rulesAudioRecording, rulesVideoRecording, rulesBroadcast, rulesPersonalCommunication, rulesInterview, rulesPresentation, rulesMap, rulesBill, rulesLegislation, rulesLegalCase, rulesReport, rulesConferencePaper)
        {
            _bibliographyProcessor = bibliographyProcessor;
        }

        #endregion

        #region Methods

        public List<KeyValuePair<string, string>> GetMetaData()
        {
            return _bibliographyProcessor.GetMetaData();
        }

        public DM.Bibliography CreateBibliography(DE.Style style, DE.Format format, List<DM.ContentItem> contentItems)
        {
            List<DM.ContentItem> contentItemsValidated = new List<DM.ContentItem>();
            List<Exception> exceptions = new List<Exception>();

            if (contentItems != null)
            {
                foreach (DM.ContentItem contentItem in contentItems)
                {
                    if (contentItem != null)
                    {
                        try
                        {
                            switch (contentItem.ItemType)
                            {
                                case DE.ItemType.Unknown:
                                    // Do Nothing
                                    break;
                                case DE.ItemType.Book:
                                    contentItemsValidated.Add(RuleManagerBook.Validate(contentItem as DM.Book));
                                    break;
                                case DE.ItemType.Chapter:
                                    contentItemsValidated.Add(RuleManagerChapter.Validate(contentItem as DM.Chapter));
                                    break;
                                case DE.ItemType.Journal:
                                    contentItemsValidated.Add(RuleManagerJournal.Validate(contentItem as DM.Journal));
                                    break;
                                case DE.ItemType.Magazine:
                                    contentItemsValidated.Add(RuleManagerMagazine.Validate(contentItem as DM.Magazine));
                                    break;
                                case DE.ItemType.Newspaper:
                                    contentItemsValidated.Add(RuleManagerNewspaper.Validate(contentItem as DM.Newspaper));
                                    break;
                                case DE.ItemType.Webpage:
                                    contentItemsValidated.Add(RuleManagerWebpage.Validate(contentItem as DM.Webpage));
                                    break;
                                case DE.ItemType.Encyclopedia:
                                    contentItemsValidated.Add(RuleManagerEncyclopedia.Validate(contentItem as DM.Encyclopedia));
                                    break;
                                case DE.ItemType.Graphic:
                                    contentItemsValidated.Add(RuleManagerGraphic.Validate(contentItem as DM.Graphic));
                                    break;
                                case DE.ItemType.AudioRecording:
                                    contentItemsValidated.Add(RuleManagerAudioRecording.Validate(contentItem as DM.AudioRecording));
                                    break;
                                case DE.ItemType.VideoRecording:
                                    contentItemsValidated.Add(RuleManagerVideoRecording.Validate(contentItem as DM.VideoRecording));
                                    break;
                                case DE.ItemType.Broadcast:
                                    contentItemsValidated.Add(RuleManagerBroadcast.Validate(contentItem as DM.Broadcast));
                                    break;
                                case DE.ItemType.PersonalCommunication:
                                    contentItemsValidated.Add(RuleManagerPersonalCommunication.Validate(contentItem as DM.PersonalCommunication));
                                    break;
                                case DE.ItemType.Interview:
                                    contentItemsValidated.Add(RuleManagerInterview.Validate(contentItem as DM.Interview));
                                    break;
                                case DE.ItemType.Presentation:
                                    contentItemsValidated.Add(RuleManagerPresentation.Validate(contentItem as DM.Presentation));
                                    break;
                                case DE.ItemType.Map:
                                    contentItemsValidated.Add(RuleManagerMap.Validate(contentItem as DM.Map));
                                    break;
                                case DE.ItemType.Bill:
                                    contentItemsValidated.Add(RuleManagerBill.Validate(contentItem as DM.Bill));
                                    break;
                                case DE.ItemType.Legislation:
                                    contentItemsValidated.Add(RuleManagerLegislation.Validate(contentItem as DM.Legislation));
                                    break;
                                case DE.ItemType.LegalCase:
                                    contentItemsValidated.Add(RuleManagerLegalCase.Validate(contentItem as DM.LegalCase));
                                    break;
                                case DE.ItemType.Report:
                                    contentItemsValidated.Add(RuleManagerReport.Validate(contentItem as DM.Report));
                                    break;
                                case DE.ItemType.ConferencePaper:
                                    contentItemsValidated.Add(RuleManagerConferencePaper.Validate(contentItem as DM.ConferencePaper));
                                    break;
                                default:
                                    throw new NotImplementedException();
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ex is AggregateException)
                            {
                                (ex as AggregateException).InnerExceptions.ToList().ForEach(x => exceptions.Add(x));
                            }
                            else
                            {
                                exceptions.Add(ex);
                            }
                        }
                    }
                }
            }

            switch (exceptions.Count)
            {
                case 0:
                    return _bibliographyProcessor.CreateBibliography(style, format, contentItemsValidated);
                case 1:
                    throw exceptions.First();
                default:
                    throw new AggregateException(exceptions);
            }
        }

        #endregion

    }

}