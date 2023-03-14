using SampleFunctionApp.Fundamentals.Interfaces.IFramework;

namespace SampleFunctionApp.Fundamentals.Classes.IApp.IAppContext.IMethodContext
{
    public interface ISessionArchive : IArchive
    {
        public string SessionIdSource { get; set; }
        public string SessionId { get; set; }
    }
}
