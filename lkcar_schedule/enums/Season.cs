using System;

namespace Snarkorel.lkcar_schedule.enums
{
    public enum Season
    {
        SUMMER,
        WINTER
    }

    public static class SeasonHelper
    {
        private const string Summer = "SUMMER";
        private const string Winter = "WINTER";

        public static string ToSeasonId(this Season value)
        {
            switch (value)
            {
                case Season.SUMMER: return Summer;
                case Season.WINTER: return Winter;
                default: throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public static Season ToSeasonEnum(this string value)
        {
            switch (value)
            {
                case Summer: return Season.SUMMER;
                case Winter: return Season.WINTER;
                default: throw new ArgumentOutOfRangeException(value);
            }
        }
    }
}
