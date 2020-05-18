using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class DateInformation
    {

        #region Constructors

        public DateInformation()
        {
            DateType = DateType.Unknown;
            DateExact = null;
            Year = null;
            Month = null;
            Day = null;
            Season = string.Empty;
            IsApproximate = false;
            DateMin = null;
            DateMax = null;
            YearMin = null;
            YearMax = null;
            MonthMin = null;
            MonthMax = null;
            DayMin = null;
            DayMax = null;
            Literal = string.Empty;
        }

        #endregion

        #region Properties

        public DateType DateType { get; set; }

        public DateTime? DateExact { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public int? Day { get; set; }

        public string Season { get; set; }

        public bool IsApproximate { get; set; }

        public DateTime? DateMin { get; set; }

        public DateTime? DateMax { get; set; }

        public int? YearMin { get; set; }

        public int? YearMax { get; set; }

        public int? MonthMin { get; set; }

        public int? MonthMax { get; set; }

        public int? DayMin { get; set; }

        public int? DayMax { get; set; }

        public string Literal { get; set; }

        #endregion

    }

}