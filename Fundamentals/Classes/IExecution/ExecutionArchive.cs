using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DateTime? Start { get; set; }
        public DateTime End { get; set; }
    }
}
