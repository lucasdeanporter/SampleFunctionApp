using System;
using System.Runtime.Versioning;
using System.Xml.Linq;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppSessionContext
{
    internal class AppSessionContextArchive
    {
        internal AppSessionContextArchive(DateTime startTime, long correlationID)
        {
            StartTimestamp = startTime;
            if (correlationID == AppSessionContextArchive.correlationID)
            {
                // Log it.
            }
            else
            {
                // Log it with failed parameters.
            }
        }

        private const string AppName = "SampleBlazorApp";

        private const long correlationID = 1111111111;

        public DateTime StartTimestamp;

        //private List<string> resourceHostnamesUsed = null;

        //private List<string> ipAddressesUsed = new List<string>();

        //private List<string> ipAddressContextID = new List<string>();

        //private methodNetworkContextArchive? executionNetworkContext = null;


    }
}
