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
            return $"Hour = {Hour}  , Minutes  = {Minutes}  , Seconds = {Seconds}";
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

        #region 4 ) Overload
        public Duration() { }
        public static Duration operator +(Duration d1 , Duration d2)
        {
            return new Duration() 
            {
                Hour = (d1?.Hour??0) + (d2?.Hour??0),
                Minutes = (d1?.Minutes ?? 0) + (d2?.Minutes ?? 0),
                Seconds = (d1?.Seconds ?? 0) + (d2?.Seconds ?? 0)
            };

        }
        public static Duration operator +(Duration d1 , int Second)
        {
            return new Duration()
            {
                Hour = (d1?.Hour ?? 0) + Second / 3600,
                Minutes = (d1?.Minutes ?? 0) +(Second %3600) /60,
                Seconds = ((d1?.Seconds ?? 0) + Second) % 60
            };

        }
        public static Duration operator ++(Duration d)
        {
            return new Duration()
            {
                Hour = d?.Hour ?? 0,
                Minutes = (d?.Minutes ?? 0) + 1,
                Seconds = (d?.Seconds ?? 0)
            };
        }
        public static Duration operator --(Duration d)
        {
            return new Duration() 
            { 
                Hour = d?.Hour??0,
                Minutes = (d?.Minutes??0) - 1,
                Seconds = (d?.Seconds??0)
            };


        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration()
            {
                Hour = (d1?.Hour ?? 0) - (d2?.Hour ?? 0),
                Minutes = (d1?.Minutes ?? 0) - (d2?.Minutes ?? 0),
                Seconds = (d1?.Seconds ?? 0) - (d2?.Seconds ?? 0)
            };

        }

        public static bool operator >(Duration left , Duration right)
        {
            if (left.Hour == right.Hour)
            {
                return left.Minutes > right.Minutes;
            }
            else 
                return left.Seconds > right.Seconds;


        }
        public static bool operator <(Duration left , Duration right)
        {
            if (left.Hour == right.Hour)
            {
                return left.Minutes < right.Minutes;
            }
            else 
                return left.Seconds < right.Seconds;


        }
        public static implicit operator bool(Duration d)
        {
            return d.Hour > 0 || d.Minutes > 0 || d.Seconds > 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(d.Hour, d.Minutes, d.Seconds);
        }

        #endregion



        #endregion


    }
}
