using SampleFunctionApp.Fundamentals.Interfaces.IFramework;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppLogic : ILogic
    {
        public IAppLogicRecord appLogicRecord { get; set; }
    }
}
