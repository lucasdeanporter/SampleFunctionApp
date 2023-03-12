using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    public interface ITimestampArchive : ITime
    {
        DateTime? Timestamp { get; set; }
    }
}
