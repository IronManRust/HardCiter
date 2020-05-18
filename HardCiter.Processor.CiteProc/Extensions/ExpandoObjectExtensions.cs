using System;
using System.Dynamic;
using Newtonsoft.Json;

namespace HardCiter.Processor.CiteProc.Extensions
{

    public static class ExpandoObjectExtensions
    {

        #region Methods

        public static string ToSerializedJSON(this ExpandoObject expandoObject)
        {
            if (expandoObject != null)
            {
                return JsonConvert.SerializeObject(expandoObject,
                                                   Formatting.None,
                                                   new JsonSerializerSettings
                                                   {
                                                       NullValueHandling = NullValueHandling.Ignore
                                                   });
            }
            else
            {
                return "{}";
            }
        }

        #endregion

    }

}