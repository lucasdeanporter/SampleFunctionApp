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
    internal class TimeRecord : ITimeRecord
    {
        TimeRecord()
        {
            timeArchive = new TimeArchive();
            HasEnd = false;
        }
        public ITimeArchive timeArchive { get; set; }
        public TimeSpan Duration { get; set; }
        public bool HasEnd { get; set; }
        public IExecutionRecord executionRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public bool NotifyWriteFailure(dynamic wasWrite)
        {
            throw new NotImplementedException(); // Todo: Implement logging here.
        }

        public bool Write(dynamic toWrite)
        {
            try
            {
                timeArchive.End = ITimeRecord.GetTimeNow;
                HasEnd = true;
                // does saving logic
                return true;
            }
            catch
            {
                try
                {
                    NotifyWriteFailure(this.timeArchive);
                    HandleWriteFailure(this.timeArchive);
                    return true;
                }
                catch
                {
                    NotifyWriteFailure(toWrite);
                    return false;
                }
            }
        }

        public bool HandleWriteFailure(dynamic toWrite)
        {
            throw new NotImplementedException();
        }
    }
}
