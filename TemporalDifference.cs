using System;
using System.Text;

namespace Time_Difference
{
    internal static class TemporalDifference
    {
        
        private static StringBuilder RemoveColon(string time)
        {
            //Stringbuilder is unneccssary, but I don't feel like changing it
            StringBuilder s = new StringBuilder(time.TrimStart());
            s.Replace(":", " ");

            return s;
        }
        
        private static int ConvertToSeconds(/*string time*/StringBuilder time)
        {
            string[] timeSplitApart = time.ToString().Split(' '); //hopefully minutes and seconds
            //string[] timeSplitApart = time.Split(':');
            int[] timeAsInts = new int[time.Length]; //stringbuilder
            //int[] timeAsInts = new int[time.Length / 2]; string

            for (int i = 0; i < timeSplitApart.Length; i++)
            {
                timeSplitApart[i] = timeSplitApart[i][0] == '0' && timeSplitApart[i].Length > 1 ?
                    timeSplitApart[i][1].ToString() : timeSplitApart[i];
                timeAsInts[i] = Convert.ToInt32(timeSplitApart[i]);
            }

            int seconds = (timeAsInts[0] * 60) + timeAsInts[1];
            return seconds;
        }

        //or accept an array, and create an array of Stringbuilders and ints with the same size as parameter array...
        public static int BetweenMinutesIntoSeconds(string minutesSeconds1, string minutesSeconds2)
        {
            StringBuilder time1 = RemoveColon(minutesSeconds1);
            StringBuilder time2 = RemoveColon(minutesSeconds2);

            int seconds1 = ConvertToSeconds(time1);
            int seconds2 = ConvertToSeconds(time2);
            //int seconds1 = ConvertToSeconds(minutesSeconds1);
            //int seconds2 = ConvertToSeconds(minutesSeconds2);

            int secondsDifference = seconds2 - seconds1;

            return Math.Abs(secondsDifference);
        }
    }
}
