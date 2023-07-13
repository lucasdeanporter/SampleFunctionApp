using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IExecution
{
    public interface IExecutionLogicRecord : ILogicRecord
    {
        public IExecutionRecord executionRecord { get; set; }
        public ITimeRecord timeRecord { get; set; }
    }
}
