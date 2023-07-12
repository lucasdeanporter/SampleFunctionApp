using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppLogicRecord : ILogicRecord
    {
        public IAppRecord appRecord { get; set; }
        public Task<dynamic> PingTest(string url);
    }
}
