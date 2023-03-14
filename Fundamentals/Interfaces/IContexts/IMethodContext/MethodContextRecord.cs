//using Microsoft.AspNetCore.SignalR;
//using System.Reflection;
//using System.Reflection.Metadata.Ecma335;

using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.IContexts.IMethodContext
{
    internal class MethodContextRecord //: IMethodContext
    {
        // do not use semicolons in messages. Harder to parse later.

        string methodContextID;

        private string startMessaging = "Starting Method: ";

        private string endMessage = "Ending Method: ";

        private bool isCompleteMethod = false;

        private string _methodName;

        private string currentStepMessage = "";

        private DateTime currentStepTimestamp;

        private DateTime startTime;

        private DateTime endTime = new DateTime();

        private string userSessionID;

        public void updateUserSessionID(string userSessionID)
        {
            currentStepTimestamp = DateTime.UtcNow;

            currentStepMessage = startMessaging + " " + "at: " + currentStepTimestamp;
            //methodContextID = app.GetMethodGUID();
        }

        internal MethodContextRecord(string methodName)
        {
            startTime = DateTime.UtcNow;
            _methodName = GetMethodName(methodName);
            string userSessionID = null;
            Start(userSessionID);
        }


        /* bool hasNetworkContext = false TODO: networking context should go in logic layer*/
        public string GetMethodName(string methodName)
        {
            if (methodName == null)
            {
                methodName = "Undefined. Not Set.";
            }
            return methodName;
            // TODO: RuntimeMethodHandle handle = new RuntimeMethodHandle();
            //string methodName = System.Reflection.MethodBase.GetMethodFromHandle(handle);
            //public MethodBase getMethod = return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        private void Start(string userSessionID)
        {

        }

        public void processMessage(string message)
        {

        }

        void end()
        {
            saveMessages();
        }

        private void saveMessages()
        {
            // log provider is implemented here.
        }
        /*
            private string beginStepMethod(string methodName)
        {
            currentMethodTime = DateTime.UtcNow;
            currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            currentStepMessage = this.beginMessage
            methodNameRecords.Add(currentMethodName);
            methodTimestampRecords.Add(currentMethodTime);
        }
        */
    }
}
