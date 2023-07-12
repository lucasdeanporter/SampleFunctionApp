using SampleFunctionApp.Fundamentals.Interfaces.IFramework;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppLogicRecord : ILogicRecord
    {
        public IAppRecord appRecord { get; set; }
    }
}
