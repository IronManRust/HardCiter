using System;

namespace HardCiter.Domain.Enums
{

    public enum DateType
    {
        Unknown = 0,
        ExactFull = 1,
        ExactPartial = 2,
        RangeFull = 3,
        RangePartial = 4,
        Literal = 5
    }

}