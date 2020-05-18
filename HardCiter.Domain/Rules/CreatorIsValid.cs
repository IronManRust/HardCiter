using System;
using System.Collections.Generic;
using System.Linq;
using HardCiter.Domain.Enums;
using HardCiter.Domain.Interfaces;
using HardCiter.Domain.Models;

namespace HardCiter.Domain.Rules
{

    public class CreatorIsValid : IRule<Book>, IRule<Chapter>, IRule<Journal>, IRule<Magazine>, IRule<Newspaper>, IRule<Webpage>, IRule<Encyclopedia>, IRule<Graphic>, IRule<AudioRecording>, IRule<VideoRecording>, IRule<Broadcast>, IRule<PersonalCommunication>, IRule<Interview>, IRule<Presentation>, IRule<Map>, IRule<Bill>, IRule<Legislation>, IRule<LegalCase>, IRule<Report>, IRule<ConferencePaper>
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
                if (instance.Creators != null &&
                    instance.Creators.Any())
                {
                    foreach (Creator creator in instance.Creators)
                    {
                        exceptions.AddRange(ProcessAndValidateCommon(creator));
                    }
                }
            }
            else
            {
                exceptions.Add(new ArgumentNullException("ContentItem"));
            }
            return instance;
        }

        private static List<Exception> ProcessAndValidateCommon(Creator creator)
        {
            List<Exception> exceptions = new List<Exception>();
            if (creator != null)
            {
                bool hasFull = !string.IsNullOrEmpty(creator.Full);
                bool hasPartial = !string.IsNullOrEmpty(creator.Given) ||
                                  !string.IsNullOrEmpty(creator.Family) ||
                                  !string.IsNullOrEmpty(creator.ParticleDropping) ||
                                  !string.IsNullOrEmpty(creator.ParticleNonDropping) ||
                                  !string.IsNullOrEmpty(creator.Family);
                if (!hasFull && !hasPartial)
                {
                    exceptions.Add(new ArgumentException("A creator must have either a full name or any name part filled out.", creator.Type.ToString()));
                }
                if (hasFull && hasPartial)
                {
                    exceptions.Add(new ArgumentException("A creator cannot have both a full name and any name part filled out.", creator.Type.ToString()));
                }
            }
            else
            {
                exceptions.Add(new ArgumentNullException("Creator"));
            }
            return exceptions;
        }

        #endregion

    }

}