using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;

namespace SampleFunctionApp.Fundamentals.Interfaces.IExecution
{
    public interface IExecutionRecord : IRecord
    {
        IExecutionArchive executionArchive { get; set; }
        ITimeRecord timeRecord { get; set; }
    }
}
