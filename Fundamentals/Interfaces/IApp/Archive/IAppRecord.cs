using SampleFunctionApp.Fundamentals.Classes.Examples;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp.Archive
{
    public interface IAppRecord : IRecord
    {
        string AppName { get; set; }
        SessionRecord SessionRecord { get; set; }
        ITimeLogic TimeRecord { get; set; } // TODO: Decide if we want an ITimeLogic here.
    }
}
