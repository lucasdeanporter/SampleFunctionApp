using SampleFunctionApp.Fundamentals.Classes.IExecution;
using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.ITime
{
    public class TimeRecord : ITimeRecord
    {
        public TimeRecord()
        {
            HasEnd = false;
        }
        public TimeArchive timeArchive { get; set; }
        public TimeSpan Duration { get; set; }
        public bool HasEnd { get; set; }
        public ExecutionRecord executionRecord { get; set; }

        public bool HasStart()
        {
            if (timeArchive.Start.HasValue)
            {
                return true;
            }
            else return false;
        }

        public bool EndTimeExists()
        {
            return HasEnd;
        }

        public int GetDuration(string secondMinuteHourOrDay)
        {
            if (EndTimeExists())
            {
                switch (secondMinuteHourOrDay)
                {
                }
                return 1; // Todo: Implement GetDuration
            }
            else
            {
                return -1;
            }
        }


        public bool NotifyWriteFailure(ITimeArchive wasWrite)
        {
            throw new NotImplementedException(); // Todo: Implement logging here.
        }

        public bool Write(ITimeArchive toWrite)
        {
            // Todo: Fix scoping from Logic to here.
            try
            {
                toWrite.End = Globals.GetTimeNow();
                HasEnd = true;
                // does saving logic
                return true;
            }
            catch
            {
                try
                {
                    NotifyWriteFailure(toWrite);
                    HandleWriteFailure(toWrite);
                    return true;
                }
                catch
                {
                    NotifyWriteFailure(toWrite);
                    return false;
                }
            }
        }

        public bool HandleWriteFailure(ITimeArchive toWrite)
        {
            return false;
        }

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

    }
}
