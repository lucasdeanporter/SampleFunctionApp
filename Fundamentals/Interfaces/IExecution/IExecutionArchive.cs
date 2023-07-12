using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System.Collections.Generic;

namespace SampleFunctionApp.Fundamentals.Interfaces.IExecution
{
    public interface IExecutionArchive : IArchive
    {
        public bool HasNetwork { get; set; }
        public bool HasUser { get; set; }
        public bool HasError { get; set; }

        public List<string> Steps { get; set; }

    }
}
