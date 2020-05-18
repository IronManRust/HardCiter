using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using DE = HardCiter.Domain.Enums;
using DM = HardCiter.Domain.Models;

namespace HardCiter.Processor.CiteProc.Models
{

    [JsonObject]
    public class DateInformation
    {

        #region Constructors

        public DateInformation()
        {
            Initialize();
        }

        public DateInformation(DM.DateInformation dateInformation)
        {
            Initialize();

            if (dateInformation != null)
            {
                switch (dateInformation.DateType)
                {
                    case DE.DateType.Unknown:
                        // Do Nothing
                        break;
                    case DE.DateType.ExactFull:
                        List<string> dateFullParts = new List<string>();
                        if (dateInformation.DateExact.HasValue)
                        {
                            dateFullParts.Add(dateInformation.DateExact.Value.Year.ToString());
                            dateFullParts.Add(dateInformation.DateExact.Value.Month.ToString());
                            dateFullParts.Add(dateInformation.DateExact.Value.Day.ToString());
                        }
                        DateParts.Add(dateFullParts);
                        break;
                    case DE.DateType.ExactPartial:
                        List<string> datePartialParts = new List<string>();
                        if (dateInformation.Year.HasValue)
                        {
                            datePartialParts.Add(dateInformation.Year.Value.ToString());
                        }
                        if (dateInformation.Month.HasValue)
                        {
                            datePartialParts.Add(dateInformation.Month.Value.ToString());
                        }
                        if (dateInformation.Day.HasValue)
                        {
                            datePartialParts.Add(dateInformation.Day.Value.ToString());
                        }
                        DateParts.Add(datePartialParts);
                        if (!string.IsNullOrEmpty(dateInformation.Season))
                        {
                            Season = dateInformation.Season;
                        }
                        if (dateInformation.IsApproximate)
                        {
                            Circa = "1";
                        }
                        break;
                    case DE.DateType.RangeFull:
                        List<string> dateFullMinParts = new List<string>();
                        if (dateInformation.DateMin.HasValue)
                        {
                            dateFullMinParts.Add(dateInformation.DateMin.Value.Year.ToString());
                            dateFullMinParts.Add(dateInformation.DateMin.Value.Month.ToString());
                            dateFullMinParts.Add(dateInformation.DateMin.Value.Day.ToString());
                        }
                        DateParts.Add(dateFullMinParts);
                        List<string> dateFullMaxParts = new List<string>();
                        if (dateInformation.DateMax.HasValue)
                        {
                            dateFullMaxParts.Add(dateInformation.DateMax.Value.Year.ToString());
                            dateFullMaxParts.Add(dateInformation.DateMax.Value.Month.ToString());
                            dateFullMaxParts.Add(dateInformation.DateMax.Value.Day.ToString());
                        }
                        DateParts.Add(dateFullMaxParts);
                        break;
                    case DE.DateType.RangePartial:
                        List<string> datePartialMinParts = new List<string>();
                        if (dateInformation.YearMin.HasValue)
                        {
                            datePartialMinParts.Add(dateInformation.YearMin.Value.ToString());
                        }
                        if (dateInformation.MonthMin.HasValue)
                        {
                            datePartialMinParts.Add(dateInformation.MonthMin.Value.ToString());
                        }
                        if (dateInformation.DayMin.HasValue)
                        {
                            datePartialMinParts.Add(dateInformation.DayMin.Value.ToString());
                        }
                        DateParts.Add(datePartialMinParts);
                        List<string> datePartialMaxParts = new List<string>();
                        if (dateInformation.YearMax.HasValue)
                        {
                            datePartialMaxParts.Add(dateInformation.YearMax.Value.ToString());
                        }
                        if (dateInformation.MonthMax.HasValue)
                        {
                            datePartialMaxParts.Add(dateInformation.MonthMax.Value.ToString());
                        }
                        if (dateInformation.DayMax.HasValue)
                        {
                            datePartialMaxParts.Add(dateInformation.DayMax.Value.ToString());
                        }
                        DateParts.Add(datePartialMaxParts);
                        break;
                    case DE.DateType.Literal:
                        if (!string.IsNullOrEmpty(dateInformation.Literal))
                        {
                            Literal = dateInformation.Literal;
                        }
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private void Initialize()
        {
            DateParts = new List<List<string>>();
            Season = string.Empty;
            Circa = string.Empty;
            Literal = string.Empty;
        }

        #endregion

        #region Properties

        [JsonProperty("date-parts")]
        public List<List<string>> DateParts { get; private set; }

        [JsonProperty("season")]
        public string Season { get; private set; }

        [JsonProperty("circa")]
        public string Circa { get; private set; }

        [JsonProperty("literal")]
        public string Literal { get; private set; }

        #endregion

    }

}