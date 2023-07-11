using SampleFunctionApp.Fundamentals.Classes.IGeneral;
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
        public IAppRecord appRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ITimeRecord timeRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IExecutionRecord executionRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool HandleWriteFailure(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        public bool NotifyWriteFailure(dynamic wasWrite)
        {
            throw new NotImplementedException();
        }

        public bool Write(dynamic toWrite)
        {
            throw new NotImplementedException();
        }
    }
}
