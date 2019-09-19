using System;

namespace Snarkorel.lkcar_schedule.enums
{
    public enum DaysOfOperation
    {
        Weekdays,
        Weekend
    }

    public static class DaysOfOperationHelper
    {
        private const string Weekdays = "WEEKDAYS";
        private const string Weekend = "WEEKEND";

        public static string ToDayId(this DaysOfOperation value)
        {
            switch (value)
            {
                case DaysOfOperation.Weekdays: return Weekdays;
                case DaysOfOperation.Weekend: return Weekend;
                default: throw new ArgumentOutOfRangeException(value.ToString());
            }
        }

        public static DaysOfOperation ToDayEnum(this string value)
        {
            switch (value)
            {
                case Weekdays: return DaysOfOperation.Weekdays;
                case Weekend: return DaysOfOperation.Weekend;
                default: throw new ArgumentOutOfRangeException(value);
            }
        }
    }
}
