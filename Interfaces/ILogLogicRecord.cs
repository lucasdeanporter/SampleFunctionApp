using SampleFunctionApp.Fundamentals.Features;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.IGeneral;

namespace SampleFunctionApp.Interfaces
{
    public interface ILogLogicRecord : ILogicRecord, ILog
    {
        ILogRecord LogRecord { get; set; }
        ISessionRecord SessionRecord { get; set; }
        IDurationRecord DurationRecord { get; set; }
    }
}
