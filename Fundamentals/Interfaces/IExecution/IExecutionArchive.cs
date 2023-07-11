using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IExecution
{
    public interface IExecutionArchive : IArchive, ITimeArchive
    {
        public bool HasNetwork { get; set; }
        public bool HasUser { get; set; }
        public bool HasError { get; set; }

        public List<string> Steps { get; set; }
        public List<object> Result { get; set; }

    }
}
