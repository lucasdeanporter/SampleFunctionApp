using System;
using System.Collections.Generic;

namespace SampleFunctionApp.Features.MethodContext
{
    internal class MethodContextArchive : IMethodContext
    {
        // these are related with general operations, easier to think in terms of a method that executes as a client interaction to a website.

        MethodContextArchive(string correlationID, string methodID)
        {
            this.correlationID = correlationID;
        }

        private string correlationID;

        private List<string> methodNameRecords = new List<string>() { };

        private List<string> methodStepMessages = new List<string>() { };

        private List<string> methodNames = new List<string>() { };

        private DateTime? clientMethodStartTime = null;

        private DateTime? clientMethodEndTime = null;

        public long messageCount = 0;
        private void addMessageCount()
        {

        }

    }
}
