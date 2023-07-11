using SampleFunctionApp.Fundamentals.Classes.ITime;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    public interface ITimeRecord : IRecord
    {
        public TimeArchive timeArchive { get; set; }
        public TimeSpan Duration { get; set; }
        public bool HasEnd { get; set; }
        public bool HasStart();
        public int GetDuration(string secondMinuteHourOrDay);
        public bool EndTimeExists();
    }
}
