using System;

namespace tecweb2.webapi.Extensions
{
    public static class DateTimeOffsetExtension
    {
        public static DateTimeOffset GetBrDateTime(this DateTimeOffset utc)
        {
#if DEBUG
            return utc;
#endif

            var kstZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            var horaBrasilia = TimeZoneInfo.ConvertTime(utc, kstZone);
            return horaBrasilia;
        }
    }
}