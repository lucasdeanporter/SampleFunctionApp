using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    //TODO: Do this other places.
    public interface IDurationRecord : IDurationArchive, IRecord, ITime
    {
        DateTime Start { get; set; }
        DateTime End { get; set; }
        TimeSpan Duration { get; set; }
        int GetDuration(string secondMinuteHourOrDay);
        bool StartTimeExists();
        bool EndTimeExists()
    }
}