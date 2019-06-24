using System;
using System.Collections.Generic;
using System.Text;

namespace Theatre
{
    class Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}"; 
        }
        public static bool operator ==(Time lhs,Time rhs)
        {
          return ((lhs.Hours*60)+lhs.Minutes-((rhs.Hours * 60) + rhs.Minutes) < 15)? true:false;
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            return ((lhs.Hours * 60) + lhs.Minutes - ((rhs.Hours * 60) + rhs.Minutes) >= 15) ? true : false;
        }
    }
}
