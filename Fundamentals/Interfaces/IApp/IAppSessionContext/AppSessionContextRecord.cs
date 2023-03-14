using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppSessionContext
{
    internal class AppSessionContextRecord
    {
        AppContextArchive sessionArchive; // closest to database. Should not do a lot of logic, should just be what the data looks like.
        private AppStartArchive startArchive; // these only need to be accessible here.
        private AppEndArchive endArchive;
        private AppRuntimeArchive runtimeArchive;
        internal AppSessionContextRecord(DateTime startTime, long correlationID)
        {
            sessionArchive = new AppContextArchive(startTime, correlationID);
            startArchive = new AppStartArchive(startTime, correlationID);
            // execute archive here.
        }

        internal bool sessionUpdate()
        {
            //sessionArchive
            return true;
        }

        internal bool endSession()
        {
            //runtimeArchive
            //endArchive
            return true;
        }
    }
}
