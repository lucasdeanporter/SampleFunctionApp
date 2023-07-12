using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;

namespace SampleFunctionApp.Fundamentals.Classes.IExecution
{
    public class ExecutionRecord : IExecutionRecord
    {
        public ExecutionRecord(IExecutionArchive executionArchive) 
        {
            this.executionArchive = executionArchive;
        }
        public IExecutionArchive executionArchive { get; set; }

        public bool HandleWriteFailure(dynamic toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(dynamic wasWrite)
        {
            return false;
        }

        public bool Write(dynamic toWrite)
        {
            return false;
        }

        public bool HandleWriteFailure(IExecutionArchive toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(IExecutionArchive wasWrite)
        {
            return false;
        }

        public bool Write(IExecutionArchive toWrite)
        {
            return false;
        }
    }
}
