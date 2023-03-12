using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    public interface IDurationArchive : IArchive, ITime
    {
        DateTime Start { get; set; }
        DateTime End { get; set; }
        TimeSpan Duration { get; set; }
    }
}
