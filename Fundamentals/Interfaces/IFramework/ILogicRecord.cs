using SampleFunctionApp.Fundamentals.Interfaces.IDo;

namespace SampleFunctionApp.Fundamentals.Interfaces.IFramework
{
    public interface ILogicRecord : IReadWrite, IFramework
    {
        // Intended usually to house multiple IRecords. Couples with an ILogic.
    }
}
