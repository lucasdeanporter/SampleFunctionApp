using SampleFunctionApp.Fundamentals.Features;
using SampleFunctionApp.Fundamentals.Interfaces.IContexts.IMethodContext;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;

namespace SampleFunctionApp.Interfaces
{
    public interface ILogLogicRecord : ILogicRecord, ILog
    {
        ILogRecord LogRecord { get; set; }
        ISessionRecord SessionRecord { get; set; }
        internal IDurationRecord DurationRecord { get; set; }
    }
}
