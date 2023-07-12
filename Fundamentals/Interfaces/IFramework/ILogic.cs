using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;

namespace SampleFunctionApp.Fundamentals.Interfaces.IFramework
{
    public interface ILogic : IRead, IFramework, IRelate
    {
        // Intended for complex logic, possibly involving multiple records, for reading and writing data. Interfaces with IDisplays (optionally, see IDisplay) and ILogicRecords (inherits from IRecord).
        IExecutionRecord executionRecord { get; set; }
    }
}
