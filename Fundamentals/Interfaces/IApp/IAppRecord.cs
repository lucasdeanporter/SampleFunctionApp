using SampleFunctionApp.Fundamentals.Interfaces.IFramework;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppRecord : IRecord
    {
        public IAppArchive appArchive { get; set; }
    }
}
