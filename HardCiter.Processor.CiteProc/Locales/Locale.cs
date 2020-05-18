using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace HardCiter.Processor.CiteProc.Locales
{

    internal static class Locale
    {

        #region Methods

        internal static string GetLocale()
        {
            using (Stream stream = typeof(Locale).GetTypeInfo().Assembly.GetManifestResourceStream(GetLocalePath()))
            {
                using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        private static string GetLocalePath()
        {
            // For now, we only support US English.
            return "HardCiter.Processor.CiteProc.Locales.locales-en-US.xml";
        }

        #endregion

    }

}