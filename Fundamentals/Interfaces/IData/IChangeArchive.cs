using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.IData
{
    public interface IChangeArchive : IArchive, IChange
    {
        string CreatedByUserId { get; set; }
        DateTime CreatedByTimestamp { get; set; }
        string ModifiedByUserId { get; set; }
        DateTime ModifiedByTimestamp { get; set; }
    }
}
