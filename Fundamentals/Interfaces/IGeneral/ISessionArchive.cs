using SampleFunctionApp.Fundamentals.Interfaces.IFramework;

namespace SampleFunctionApp.Fundamentals.Interfaces.IGeneral
{
    public interface ISessionArchive : IArchive, IGeneral
    {
        public string SessionIdSource { get; set; }
        public string SessionId { get; set; }
    }
}
