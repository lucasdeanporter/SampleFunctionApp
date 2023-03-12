using System;
using System.Collections.Generic;

namespace SampleFunctionApp.Classes.IAppSessionContext
{
    public class AppSessionContextLogicRecord
    {
        // need a timer for method steps here, durations. Could be a good concern area for this.
        internal const bool AppStartup = true; // controls directly the startup of application.
        private const string appName = "SampleBlazorApp";
        private const long correlationID = 1111111111; // compare with one passed to private values hardcoded.

        internal bool IsFirstRun = true;
        internal DateTime? FirstRunTimestamp = null;


        private DateTime? _appStartupTimestamp = null;
        internal DateTime? AppStartTimestamp
        {
            get
            {
                return _appStartupTimestamp;
            }
            set
            {
                if (AppStartup && IsFirstRun)
                {
                    _appStartupTimestamp = value;
                }
            }
        }

        private List<string> methodContextIDs = new List<string>();


        public AppSessionContextLogicRecord()
        {
            if (AppStartup)
            {
                AppStartTimestamp = DateTime.UtcNow;
            }
            else
            {
                // TODO: Do something when things are accessed weirdly. Let users know.
            }
        }


        void AutoSave() { } // implement with timer.



        private Guid _guid = Guid.NewGuid(); // TODO: Danger, test this, see alternatives.
        internal string GetMethodGUID()
        {
            if (IsFirstRun)
            {
                IsFirstRun = false;
            }
            string result = _guid.ToString();
            methodContextIDs.Add(result);

            return result;

        }
    }
}
