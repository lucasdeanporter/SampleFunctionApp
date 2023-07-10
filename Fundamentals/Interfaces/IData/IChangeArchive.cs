using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.IData
{
    public interface IChangeArchive : IArchive, IChange, ITimeArchive
    {
        string CreatedByUserId { get; set; }
        DateTime CreatedByTimestamp { get; set; }
        string ModifiedByUserId { get; set; }
        DateTime ModifiedByTimestamp { get; set; }
    }
}
