using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppLogicRecord : ILogicRecord
    {
        public IAppRecord appRecord { get; set; }
        public Task<dynamic> PingTest(string url);
    }
}
