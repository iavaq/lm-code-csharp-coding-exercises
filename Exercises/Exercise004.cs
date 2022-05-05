using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            TimeSpan gigasec = new TimeSpan(11574, 1, 46, 40);
            return dateTime+gigasec;
        }
    }
}
