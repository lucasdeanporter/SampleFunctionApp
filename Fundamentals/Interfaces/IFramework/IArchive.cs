using SampleFunctionApp.Fundamentals.Interfaces.IDo;

namespace SampleFunctionApp.Fundamentals.Interfaces.IFramework
{
    public interface IArchive : IRead, IRelate, IFramework
    {
        // Intended to only be concerned with storing data in basic parameters. Interfaces with IRecords.
    }
}
