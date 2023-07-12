using SampleFunctionApp.Fundamentals.Interfaces.IFramework;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppArchive : IArchive
    {
        public string AppName { get; }
    }
}
