using SampleFunctionApp.Fundamentals.Interfaces.IApp;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppRecord : IAppRecord
    {
        public AppRecord(IAppArchive appArchive) 
        {
            this.appArchive = appArchive;
        }
        public IAppArchive appArchive { get; set; }

        public string test = "testing";

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
