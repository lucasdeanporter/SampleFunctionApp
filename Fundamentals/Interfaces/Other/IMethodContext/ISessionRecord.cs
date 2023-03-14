using SampleFunctionApp.Fundamentals.Interfaces.IFramework;

namespace SampleFunctionApp.Fundamentals.Classes.IApp.IAppContext.IMethodContext
{
    public interface ISessionRecord : ISessionArchive, IRecord
    {
        //SessionArchive SessionArchive { get; set; }
        void SetSessionId(string sessionId);
        void SetSessionId(object sessionId);
        void SetSessionId(long sessionId);
        void SetSessionId(int sessionId);
        dynamic GetSessionId();

    }
}
