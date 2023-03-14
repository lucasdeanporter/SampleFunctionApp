using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    //TODO: Do this other places.
    internal interface IDurationRecord : IDurationArchive, IRecord
    {
        ITimeRecord timeRecord { get; set; }
        TimeSpan Duration { get; set; }
        int GetDuration(string secondMinuteHourOrDay);
        bool StartTimeExists();
        bool EndTimeExists();
    }
}