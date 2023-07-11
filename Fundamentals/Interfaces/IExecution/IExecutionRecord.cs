using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IExecution
{
    public interface IExecutionRecord : IRecord
    {
        IExecutionArchive executionArchive { get; set; }
    }
}
