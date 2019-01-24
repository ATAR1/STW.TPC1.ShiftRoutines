using System;

namespace STW.TPC1.ShiftRoutines
{
    public class TimeInterval
    {
        public TimeInterval(int startTime, int nextIntervalStartTime)
        {
            StartTime = TimeSpan.FromHours(startTime);
            EndTime = TimeSpan.FromHours( nextIntervalStartTime).Add(TimeSpan.FromTicks(-1));
        }
        public TimeSpan StartTime { get;}

        public TimeSpan EndTime { get;}
    }
}