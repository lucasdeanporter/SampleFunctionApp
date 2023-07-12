using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using System;
using System.Collections.Generic;

namespace SampleFunctionApp.Fundamentals.Classes.IExecution
{
    internal class ExecutionArchive : IExecutionArchive
    {
        public DateTime relateId { get; set; }
        public bool HasNetwork { get; set; }
        public bool HasUser { get; set; }
        public bool HasError { get; set; }
        public List<string> Steps { get; set; }
        public List<object> Result { get; set; }
    }
}
