using System;
using System.Collections.Generic;
using System.Linq;
using HardCiter.Domain.Interfaces;

namespace HardCiter.Domain.Managers
{

    public class RuleManager<T> where T : class
    {

        #region Variables

        private List<IRule<T>> _rules;

        #endregion

        #region Constructors

        public RuleManager()
        {
            _rules = new List<IRule<T>>();
        }

        public RuleManager(List<IRule<T>> rules)
        {
            _rules = rules != null ? rules.Where(x => x != null).ToList()
                                   : new List<IRule<T>>();
        }

        #endregion

        #region Methods

        public void AddRule(IRule<T> rule)
        {
            if (rule != null)
            {
                _rules.Add(rule);
            }
        }

        public T Validate(T instance)
        {
            if (instance != null)
            {
                List<Exception> exceptions = new List<Exception>();
                bool shouldSuppressProcessing = false;

                foreach (IRule<T> rule in _rules)
                {
                    List<Exception> validations = new List<Exception>();
                    bool shouldSuppressProcessingRule = false;

                    instance = rule.ProcessAndValidate(instance, out validations, out shouldSuppressProcessingRule);

                    if (validations != null)
                    {
                        exceptions.AddRange(validations.Where(x => x != null));
                    }
                    shouldSuppressProcessing = shouldSuppressProcessing || shouldSuppressProcessingRule;
                }

                switch (exceptions.Count)
                {
                    case 0:
                        return shouldSuppressProcessing ? null : instance;
                    case 1:
                        throw exceptions.First();
                    default:
                        throw new AggregateException(exceptions);
                }
            }
            else
            {
                throw new ArgumentNullException(typeof(T).Name);
            }
        }

        #endregion

    }

}