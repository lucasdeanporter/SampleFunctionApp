using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    public interface ITimeRecord : IRecord
    {
        public ITimeArchive timeArchive { get; set; }
        public TimeSpan Duration { get; set; }
        public bool HasEnd { get; set; }
        public bool HasStart();
        public int GetDuration(string secondMinuteHourOrDay);
        public bool EndTimeExists();
    }
}
