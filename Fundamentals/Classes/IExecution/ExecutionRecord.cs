using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IExecution
{
    public class ExecutionRecord : IExecutionRecord
    {
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
