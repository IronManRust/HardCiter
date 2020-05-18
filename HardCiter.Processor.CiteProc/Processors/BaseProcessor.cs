using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.NodeServices;
using Newtonsoft.Json;
using HardCiter.Processor.CiteProc.Models;

namespace HardCiter.Processor.CiteProc.Processors
{

    public abstract class BaseProcessor
    {

        #region Constants

        private const string PATH = "HardCiter.Processor.CiteProc.Processors";

        #endregion

        #region Constructors

        public BaseProcessor(INodeServices nodeServices)
        {
            NodeServices = nodeServices;
        }

        #endregion

        #region Properties

        protected abstract string JavaScriptFilename { get; }

        protected INodeServices NodeServices { get; private set; }

        #endregion

        #region Methods

        protected List<KeyValuePair<string, string>> GetMetaDataShared()
        {
            LibraryInformation libraryInformation = GetLibraryInformation().Result;

            List<KeyValuePair<string, string>> metaData = new List<KeyValuePair<string, string>>();
            metaData.Add(new KeyValuePair<string, string>("Library Name", libraryInformation.Name));
            metaData.Add(new KeyValuePair<string, string>("Library Version", libraryInformation.Version));
            metaData.Add(new KeyValuePair<string, string>("Library Runtime", libraryInformation.Runtime));
            return metaData;
        }

        private async Task<LibraryInformation> GetLibraryInformation()
        {
            using (StringAsTempFile file = new StringAsTempFile(GetResource($"{PATH}.BaseProcessor.js"), CancellationToken.None))
            {
                string result = await NodeServices.InvokeAsync<string>(file.FileName, GetLibrary());
                LibraryInformation libraryInformation = JsonConvert.DeserializeObject<LibraryInformation>(result);
                return libraryInformation;
            }
        }

        protected string GetContents()
        {
            return GetResource($"{PATH}.{JavaScriptFilename}");
        }

        protected static string GetLibrary()
        {
            return GetResource($"{PATH}.CiteProc.js");
        }

        private static string GetResource(string path)
        {
            using (Stream stream = typeof(BaseProcessor).GetTypeInfo().Assembly.GetManifestResourceStream(path))
            {
                using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        #endregion

    }

}