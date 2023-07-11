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
        public DateTime relateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HasNetwork { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HasUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HasError { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Steps { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<object> Result { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? Start { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime End { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
