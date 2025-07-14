using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUpdated.Q5.Part02
{
    internal class Duration
    {
        #region 1
        public int Hour { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion
        #region 2
        public override string ToString()
        {
            string result = "";

            if (Hour > 0)
                result += $"Hours: {Hour}, ";

            if (Minutes > 0 || Hour > 0 || Seconds > 0)
                result += $"Minutes: {Minutes}, ";

            result += $"Seconds: {Seconds}";

            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return this.Hour == other.Hour &&
                       this.Minutes == other.Minutes &&
                       this.Seconds == other.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hour, Minutes, Seconds);
        }

        #endregion
        #region 3
        public Duration(int totalSeconds)
        {
            Hour = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }
        public Duration(int hour, int minutes, int seconds)
        {
            Hour = hour;
            Minutes = minutes;
            Seconds = seconds;
        }
       




        #endregion


    }
}
