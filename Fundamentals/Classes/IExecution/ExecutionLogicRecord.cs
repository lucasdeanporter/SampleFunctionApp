using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IExecution
{
    internal class ExecutionLogicRecord : IExecutionLogicRecord
    {
        public IExecutionRecord executionRecord { get; set; }
        public ITimeRecord timeRecord { get; set; }

        public ExecutionLogicRecord(IExecutionRecord executionRecord, ITimeRecord timeRecord) 
        {
            this.timeRecord = timeRecord;
            this.executionRecord = executionRecord;
        }
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


        public bool HandleWriteFailure(IExecutionRecord toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(IExecutionRecord wasWrite)
        {
            return false;
        }

        public bool Write(IExecutionRecord toWrite)
        {
            return false;
        }

        public bool HandleWriteFailure(ITimeRecord toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(ITimeRecord wasWrite)
        {
            return false;
        }

        public bool Write(ITimeRecord toWrite)
        {
            return false;
        }
    }
}
