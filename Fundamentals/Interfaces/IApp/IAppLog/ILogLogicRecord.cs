using SampleFunctionApp.Fundamentals.Classes.IApp.IAppContext.IMethodContext;
using SampleFunctionApp.Fundamentals.Features;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppLog
{
    public interface ILogLogicRecord : ILogicRecord, ILog
    {
        ILogRecord LogRecord { get; set; }
        ISessionRecord SessionRecord { get; set; }
        internal IDurationRecord DurationRecord { get; set; }
    }
}
