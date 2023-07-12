using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;

namespace SampleFunctionApp.Fundamentals.Classes.IExecution
{
    public class ExecutionRecord : IExecutionRecord
    {
        public IExecutionArchive executionArchive { get; set; }
        public ITimeRecord timeRecord { get; set; }

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
