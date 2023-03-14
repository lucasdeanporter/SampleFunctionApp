using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    internal class AppStartArchive
    {
        public readonly DateTime StartTimestamp;
        private readonly long correlationID;

        internal AppStartArchive(DateTime startTimestamp, long correlationID)
        {
            StartTimestamp = startTimestamp;
            this.correlationID = correlationID;
        }
    }
}
