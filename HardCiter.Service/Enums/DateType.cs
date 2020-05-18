using System;

namespace HardCiter.Service.Enums
{

    /// <summary>
    /// The date type.
    /// </summary>
    public enum DateType
    {

        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// ExactFull
        /// </summary>
        ExactFull = 1,

        /// <summary>
        /// ExactPartial
        /// </summary>
        ExactPartial = 2,

        /// <summary>
        /// RangeFull
        /// </summary>
        RangeFull = 3,

        /// <summary>
        /// RangePartial
        /// </summary>
        RangePartial = 4,

        /// <summary>
        /// Literal
        /// </summary>
        Literal = 5

    }

}