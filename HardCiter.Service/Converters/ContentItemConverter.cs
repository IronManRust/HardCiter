using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HardCiter.Service.Enums;
using HardCiter.Service.Models;

namespace HardCiter.Service.Converters
{

    /// <summary>
    /// Handles converting abstract ContentItem objects into their concrete types.
    /// </summary>
    public class ContentItemConverter : JsonConverter
    {

        #region Methods

        /// <summary>
        /// Indicates if the object can be converted.
        /// </summary>
        /// <param name="objectType">
        /// The type of the object to be converted.
        /// </param>
        /// <returns>
        /// If the object can be converted.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ContentItem);
        }

        /// <summary>
        /// Performs a JSON-to-Object conversion.
        /// </summary>
        /// <param name="reader">
        /// A JsonReader object.
        /// </param>
        /// <param name="objectType">
        /// The type of the object.
        /// </param>
        /// <param name="existingValue">
        /// The existing value.
        /// </param>
        /// <param name="serializer">
        /// A JsonSerializer object.
        /// </param>
        /// <returns>
        /// A converted object.
        /// </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            const string ITEM_TYPE_KEY = "ItemType";
            const string ARGUMENT_EXCEPTON = "Invalid Or Missing ItemType";

            ContentItem contentItem = null;
            ItemType itemType = ItemType.Unknown;

            JObject jObject = JObject.Load(reader);
            JToken jToken = null;

            if (jObject.TryGetValue(ITEM_TYPE_KEY, StringComparison.CurrentCultureIgnoreCase, out jToken) && jToken != null && Enum.TryParse(jToken.Value<string>(), true, out itemType))
            {
                switch (itemType)
                {
                    case ItemType.Unknown:
                        throw new ArgumentException(ARGUMENT_EXCEPTON);
                    case ItemType.Book:
                        contentItem = new Book();
                        break;
                    case ItemType.Chapter:
                        contentItem = new Chapter();
                        break;
                    case ItemType.Journal:
                        contentItem = new Journal();
                        break;
                    case ItemType.Magazine:
                        contentItem = new Magazine();
                        break;
                    case ItemType.Newspaper:
                        contentItem = new Newspaper();
                        break;
                    case ItemType.Webpage:
                        contentItem = new Webpage();
                        break;
                    case ItemType.Encyclopedia:
                        contentItem = new Encyclopedia();
                        break;
                    case ItemType.Graphic:
                        contentItem = new Graphic();
                        break;
                    case ItemType.AudioRecording:
                        contentItem = new AudioRecording();
                        break;
                    case ItemType.VideoRecording:
                        contentItem = new VideoRecording();
                        break;
                    case ItemType.Broadcast:
                        contentItem = new Broadcast();
                        break;
                    case ItemType.PersonalCommunication:
                        contentItem = new PersonalCommunication();
                        break;
                    case ItemType.Interview:
                        contentItem = new Interview();
                        break;
                    case ItemType.Presentation:
                        contentItem = new Presentation();
                        break;
                    case ItemType.Map:
                        contentItem = new Map();
                        break;
                    case ItemType.Bill:
                        contentItem = new Bill();
                        break;
                    case ItemType.Legislation:
                        contentItem = new Legislation();
                        break;
                    case ItemType.LegalCase:
                        contentItem = new LegalCase();
                        break;
                    case ItemType.Report:
                        contentItem = new Report();
                        break;
                    case ItemType.ConferencePaper:
                        contentItem = new ConferencePaper();
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                throw new ArgumentException(ARGUMENT_EXCEPTON);
            }

            if (serializer != null)
            {
                serializer.Populate(jObject.CreateReader(), contentItem);
            }
            return contentItem;
        }

        /// <summary>
        /// Performs an Object-to-JSON conversion.
        /// </summary>
        /// <param name="writer">
        /// A JsonWriter object.
        /// </param>
        /// <param name="value">
        /// The object to convert.
        /// </param>
        /// <param name="serializer">
        /// A JsonSerializer object.
        /// </param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        #endregion

    }

}