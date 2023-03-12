using System;

namespace SampleFunctionApp.Classes.IAppSessionContext
{
    internal class AppStartArchive
    {
        public readonly DateTime StartTimestamp;
        private readonly long correlationID;

        internal AppStartArchive(DateTime startTimestamp, long correlationID)
        {
            this.StartTimestamp = startTimestamp;
            this.correlationID = correlationID;
        }
    }
}
