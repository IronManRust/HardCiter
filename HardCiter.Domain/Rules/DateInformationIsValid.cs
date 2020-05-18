using System;
using System.Collections.Generic;
using System.Linq;
using HardCiter.Domain.Enums;
using HardCiter.Domain.Interfaces;
using HardCiter.Domain.Models;

namespace HardCiter.Domain.Rules
{

    public class DateInformationIsValid : IRule<Book>, IRule<Chapter>, IRule<Journal>, IRule<Magazine>, IRule<Newspaper>, IRule<Webpage>, IRule<Encyclopedia>, IRule<Graphic>, IRule<AudioRecording>, IRule<VideoRecording>, IRule<Broadcast>, IRule<PersonalCommunication>, IRule<Interview>, IRule<Presentation>, IRule<Map>, IRule<Bill>, IRule<Legislation>, IRule<LegalCase>, IRule<Report>, IRule<ConferencePaper>
    {

        #region Methods

        public Book ProcessAndValidate(Book instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Chapter ProcessAndValidate(Chapter instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Journal ProcessAndValidate(Journal instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Magazine ProcessAndValidate(Magazine instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Newspaper ProcessAndValidate(Newspaper instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Webpage ProcessAndValidate(Webpage instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Encyclopedia ProcessAndValidate(Encyclopedia instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Graphic ProcessAndValidate(Graphic instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public AudioRecording ProcessAndValidate(AudioRecording instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public VideoRecording ProcessAndValidate(VideoRecording instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Broadcast ProcessAndValidate(Broadcast instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public PersonalCommunication ProcessAndValidate(PersonalCommunication instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Interview ProcessAndValidate(Interview instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Presentation ProcessAndValidate(Presentation instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Map ProcessAndValidate(Map instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Bill ProcessAndValidate(Bill instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Legislation ProcessAndValidate(Legislation instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public LegalCase ProcessAndValidate(LegalCase instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public Report ProcessAndValidate(Report instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        public ConferencePaper ProcessAndValidate(ConferencePaper instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            ProcessAndValidateCommon(instance, out exceptions, out shouldSuppressProcessing);
            return instance;
        }

        private static ContentItem ProcessAndValidateCommon(ContentItem instance, out List<Exception> exceptions, out bool shouldSuppressProcessing)
        {
            exceptions = new List<Exception>();
            shouldSuppressProcessing = false;
            if (instance != null)
            {
                if (instance.AccessedDate != null)
                {
                    exceptions.AddRange(ProcessAndValidateCommon(instance.AccessedDate, "AccessedDate"));
                }
                if (instance.IssuedDate != null)
                {
                    exceptions.AddRange(ProcessAndValidateCommon(instance.IssuedDate, "IssuedDate"));
                }
            }
            else
            {
                exceptions.Add(new ArgumentNullException("ContentItem"));
            }
            return instance;
        }

        private static List<Exception> ProcessAndValidateCommon(DateInformation dateInformation, string field)
        {
            List<Exception> exceptions = new List<Exception>();
            if (dateInformation != null)
            {
                bool hasExactFull = dateInformation.DateExact.HasValue;
                bool hasExactPartial = dateInformation.Year.HasValue ||
                                       dateInformation.Month.HasValue ||
                                       dateInformation.Day.HasValue ||
                                       !string.IsNullOrEmpty(dateInformation.Season) ||
                                       dateInformation.IsApproximate;
                bool hasRangeFull = dateInformation.DateMin.HasValue ||
                                    dateInformation.DateMax.HasValue;
                bool hasRangePartial = dateInformation.YearMin.HasValue ||
                                       dateInformation.YearMax.HasValue ||
                                       dateInformation.MonthMin.HasValue ||
                                       dateInformation.MonthMax.HasValue ||
                                       dateInformation.DayMin.HasValue ||
                                       dateInformation.DayMax.HasValue;
                bool hasLiteral = !string.IsNullOrEmpty(dateInformation.Literal);
                List<bool> categories = new List<bool>() { hasExactFull, hasExactPartial, hasRangeFull, hasRangePartial, hasLiteral };
                switch (categories.Where(x => x).Count())
                {
                    case 0:
                        exceptions.Add(new ArgumentException("A date must have at least one type of field filled out.", field));
                        break;
                    case 1:
                        // Do Nothing
                        break;
                    default:
                        exceptions.Add(new ArgumentException("A date cannot have more than one type of field filled out.", field));
                        break;
                }
            }
            else
            {
                exceptions.Add(new ArgumentNullException("DateInformation"));
            }
            return exceptions;
        }

        #endregion

    }

}