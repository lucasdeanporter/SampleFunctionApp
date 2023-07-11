using SampleFunctionApp.Fundamentals.Classes.IExecution;
using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Classes.ITime;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppLogicRecord : IAppLogicRecord
    {
        public AppRecord appRecord { get; set; }
        public TimeRecord timeRecord { get; set; }
        public ExecutionRecord executionRecord { get; set; }

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

        public bool HandleWriteFailure(IAppRecord toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(IAppRecord wasWrite)
        {
            return false;
        }

        public bool Write(IAppRecord toWrite)
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
    }
}
