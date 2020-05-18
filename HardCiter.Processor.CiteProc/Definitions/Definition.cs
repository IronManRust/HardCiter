using System;
using System.IO;
using System.Reflection;
using System.Text;
using HardCiter.Domain.Enums;

namespace HardCiter.Processor.CiteProc.Definitions
{

    internal static class Definition
    {

        #region Methods

        internal static string GetDefinition(Style style)
        {
            using (Stream stream = typeof(Definition).GetTypeInfo().Assembly.GetManifestResourceStream(GetDefinitionPath(style)))
            {
                using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        private static string GetDefinitionPath(Style style)
        {
            const string PATH_PREFIX = "HardCiter.Processor.CiteProc.Definitions.";
            const string PATH_SUFFIX = ".csl";
            switch (style)
            {
                case Style.Unknown:
                    throw new ArgumentException("Invalid Style");
                case Style.MLA7:
                    return $"{PATH_PREFIX}modern-language-association-7th-edition{PATH_SUFFIX}";
                case Style.MLA8:
                    return $"{PATH_PREFIX}modern-language-association{PATH_SUFFIX}";
                case Style.APA5:
                    return $"{PATH_PREFIX}apa-5th-edition{PATH_SUFFIX}";
                case Style.APA6:
                    return $"{PATH_PREFIX}apa-6th-edition{PATH_SUFFIX}";
                case Style.APA7:
                    return $"{PATH_PREFIX}apa{PATH_SUFFIX}";
                case Style.Chicago17:
                    return $"{PATH_PREFIX}chicago-fullnote-bibliography{PATH_SUFFIX}";
                case Style.Harvard10:
                    return $"{PATH_PREFIX}harvard-cite-them-right{PATH_SUFFIX}";
                case Style.ASA6:
                    return $"{PATH_PREFIX}american-sociological-association{PATH_SUFFIX}";
                case Style.Turabian8:
                    return $"{PATH_PREFIX}turabian-fullnote-bibliography{PATH_SUFFIX}";
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion

    }

}