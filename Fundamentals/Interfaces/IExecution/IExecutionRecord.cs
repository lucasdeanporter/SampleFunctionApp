using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.IExecution
{
    public interface IExecutionRecord : IRecord
    {
        IExecutionArchive executionArchive { get; set; }
    }
}
