using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IExecution
{
    internal class ExecutionLogic : IExecutionLogic
    {
        public IExecutionRecord executionRecord { get; set; }

        public DateTime executionId { get; set; }
        public DateTime appRelateId { get; set; }
        public IExecutionLogicRecord ExecutionLogicRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
