using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.Extensions.Options;
using HardCiter.API;
using HardCiter.Service.Configuration;
using HardCiter.Service.Enums;
using HardCiter.Service.Models;

namespace HardCiter.Service.Managers
{

    internal class InformationManager : RootManager
    {

        #region Variables

        private IOptions<Settings> _settings;
        private BibliographyProcessor _bibliographyProcessor;
        private CitationProcessor _citationProcessor;

        #endregion

        #region Constructors

        internal InformationManager(IOptions<Settings> settings, INodeServices nodeServices)
        {
            _settings = settings;
            _bibliographyProcessor = GetBibliographyProcessor(nodeServices);
            _citationProcessor = GetCitationProcessor(nodeServices);
        }

        #endregion

        #region Methods

        internal Status GetStatus()
        {
            try
            {
                List<KeyValuePair<string, string>> metaData = new List<KeyValuePair<string, string>>();
                metaData.AddRange(GetMetaData());
                metaData.AddRange(_bibliographyProcessor.GetMetaData().Select(x => new KeyValuePair<string, string>(string.Concat("Bibliography - ", x.Key), x.Value)));
                metaData.AddRange(_citationProcessor.GetMetaData().Select(x => new KeyValuePair<string, string>(string.Concat("Citation - ", x.Key), x.Value)));
                return new Status()
                {
                    Health = Health.Healthy,
                    Environment = _settings.Value.Environment,
                    MetaData = metaData
                };
            }
            catch
            {
                return new Status()
                {
                    Health = Health.Unhealthy,
                    Environment = string.Empty,
                    MetaData = new List<KeyValuePair<string, string>>()
                };
            }
        }

        private static List<KeyValuePair<string, string>> GetMetaData()
        {
            List<KeyValuePair<string, string>> metaData = new List<KeyValuePair<string, string>>();
            metaData.Add(new KeyValuePair<string, string>("Service Version", string.Concat("v", Assembly.GetExecutingAssembly().GetName().Version.ToString())));
            metaData.Add(new KeyValuePair<string, string>("Service Build Date", File.GetCreationTime(Assembly.GetExecutingAssembly().Location).ToString()));
            metaData.Add(new KeyValuePair<string, string>("Service Runtime", Assembly.GetExecutingAssembly().GetCustomAttribute<TargetFrameworkAttribute>().FrameworkName));
            return metaData;
        }

        #endregion

    }

}