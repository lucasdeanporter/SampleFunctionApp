using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;

namespace SampleFunctionApp.Fundamentals.Interfaces.IFramework
{
    public interface ILogic : IRead, IFramework, IRelate
    {
        // Intended for complex logic, possibly involving multiple records, for reading and writing data. Interfaces with IDisplays (optionally, see IDisplay) and ILogics and its own associated LogicRecord (inherits from IRecord).
    }
}
