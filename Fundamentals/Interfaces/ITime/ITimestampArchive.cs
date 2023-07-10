using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    public interface ITimestampArchive : IArchive
    {
        DateTime? Timestamp { get; set; }
    }
}
