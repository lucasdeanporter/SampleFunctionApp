using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;

namespace SampleFunctionApp.Fundamentals.Interfaces.IFramework
{
    public interface IArchive : IRead, IRelate, IFramework
    {
        // Intended to only be concerned with storing data in basic parameters. Interfaces with IRecords.
    }
}
