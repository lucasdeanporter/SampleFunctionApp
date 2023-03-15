using SampleFunctionApp.Fundamentals.Interfaces.IDo;

namespace SampleFunctionApp.Fundamentals.Interfaces.IFramework
{
    public interface IRecord : IArchive, IReadWrite, IRelate, IFramework // this evidently needs to be a configured service with DI https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection
    {
        // Intended to read and write with IArchives. These can be used for simpler implementations of software and can substitue as IDisplays or ViewModels. Interfaces with IArchives and ILogics.
    }
}
