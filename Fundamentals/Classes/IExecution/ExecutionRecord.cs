using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IExecution
{
    internal class ExecutionRecord : IExecutionRecord
    {
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
