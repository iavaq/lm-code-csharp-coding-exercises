﻿using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            //implementing refactoring feedback:
            return dateTime.AddSeconds(1e9);  

            /* orginal submission:
            //1 gigasec calculated to timespan of 11574 days, 1 hour, 46 minutes, 40 seconds.
            TimeSpan gigasec = new TimeSpan(11574, 1, 46, 40);
            return dateTime+gigasec;
            */
        }
    }
}
