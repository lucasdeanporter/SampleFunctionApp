using SampleFunctionApp.Fundamentals.Interfaces.IApp;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppRecord : IAppRecord
    {
        public IAppArchive appArchive { get; set; }

        public bool HandleWriteFailure(dynamic toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(dynamic wasWrite)
        {
            return false;
        }

        public bool Write(dynamic toWrite)
        {
            return false;
        }


        bool HandleWriteFailure(IAppArchive toWrite)
        {
            return false;
        }

        bool NotifyWriteFailure(IAppArchive wasWrite)
        {
            return false;
        }

        bool Write(IAppArchive toWrite)
        {
            return false;
        }
    }
}
