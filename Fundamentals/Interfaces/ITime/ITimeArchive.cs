using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    public interface ITimeArchive : IArchive
    {
        public DateTime? Start { get; set; }
        public DateTime End { get; set; }
    }
}
