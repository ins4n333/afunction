using System;

namespace TestFuncLib
{
    public static class DateTimeHelper
    {
        public static DateTime GetCurrentDateTime()
        {
            return DateTime.UtcNow;
        }
    }
}