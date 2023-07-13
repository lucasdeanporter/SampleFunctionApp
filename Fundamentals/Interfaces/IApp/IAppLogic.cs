using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppLogic : ILogic
    {
        public IAppLogicRecord appLogicRecord { get; set; }
        public IExecutionLogic executionLogic { get; set; }
        public ValueTask<dynamic> PingTest();
    }
}
