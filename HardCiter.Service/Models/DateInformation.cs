using System;
using HardCiter.Service.Enums;

namespace HardCiter.Service.Models
{

    /// <summary>
    /// Describes information pertaining to a date.
    /// </summary>
    public class DateInformation
    {

        #region Constructors

        /// <summary>
        /// Initializes an object describing information pertaining to a date.
        /// </summary>
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

        /// <summary>
        /// The date type.
        /// </summary>
        /// <value>
        /// The date type.
        /// </value>
        public DateType DateType { get; set; }

        /// <summary>
        /// The exact date.
        /// </summary>
        /// <value>
        /// The exact date.
        /// </value>
        public DateTime? DateExact { get; set; }

        /// <summary>
        /// The exact date's year.
        /// </summary>
        /// <value>
        /// The exact date's year.
        /// </value>
        public int? Year { get; set; }

        /// <summary>
        /// The exact date's month.
        /// </summary>
        /// <value>
        /// The exact date's month.
        /// </value>
        public int? Month { get; set; }

        /// <summary>
        /// The exact date's day.
        /// </summary>
        /// <value>
        /// The exact date's day.
        /// </value>
        public int? Day { get; set; }

        /// <summary>
        /// The exact date's season.
        /// </summary>
        /// <value>
        /// The exact date's season.
        /// </value>
        public string Season { get; set; }

        /// <summary>
        /// Indicates if the exact date is actually approximate.
        /// </summary>
        /// <value>
        /// Indicates if the exact date is actually approximate.
        /// </value>
        public bool IsApproximate { get; set; }

        /// <summary>
        /// The minimum date in a range.
        /// </summary>
        /// <value>
        /// The minimum date in a range.
        /// </value>
        public DateTime? DateMin { get; set; }

        /// <summary>
        /// The maximum date in a range.
        /// </summary>
        /// <value>
        /// The maximum date in a range.
        /// </value>
        public DateTime? DateMax { get; set; }

        /// <summary>
        /// The minimum date in a range's year.
        /// </summary>
        /// <value>
        /// The minimum date in a range's year.
        /// </value>
        public int? YearMin { get; set; }

        /// <summary>
        /// The maximum date in a range's year.
        /// </summary>
        /// <value>
        /// The maximum date in a range's year.
        /// </value>
        public int? YearMax { get; set; }

        /// <summary>
        /// The minimum date in a range's month.
        /// </summary>
        /// <value>
        /// The minimum date in a range's month.
        /// </value>
        public int? MonthMin { get; set; }

        /// <summary>
        /// The maximum date in a range's month.
        /// </summary>
        /// <value>
        /// The maximum date in a range's month.
        /// </value>
        public int? MonthMax { get; set; }

        /// <summary>
        /// The minimum date in a range's day.
        /// </summary>
        /// <value>
        /// The minimum date in a range's day.
        /// </value>
        public int? DayMin { get; set; }

        /// <summary>
        /// The maximum date in a range's day.
        /// </summary>
        /// <value>
        /// The maximum date in a range's day.
        /// </value>
        public int? DayMax { get; set; }

        /// <summary>
        /// A literal or non-standard date.
        /// </summary>
        /// <value>
        /// A literal or non-standard date.
        /// </value>
        public string Literal { get; set; }

        #endregion

    }

}